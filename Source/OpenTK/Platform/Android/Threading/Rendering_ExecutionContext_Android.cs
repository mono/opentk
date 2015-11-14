using System;
using OpenTK.Platform.Android;
using System.Threading;

namespace OpenTK.Platform.Android.Threading
{
	/// <summary>
	/// Rendering execution context. For now it is not thread safe and it is assumed it will be executed in the UI / Main thread
	/// </summary>
	public class Rendering_ExecutionContext_Android :  IExecutionContext
	{
		private BackgroundLooper context;
		private ExecutionState state = ExecutionState.Stop;

		public event EventHandler<ExecutionStateChangedEventArgs> ExecutionStateChanged;
		public event EventHandler<ThreadExceptionEventArgs> ExceptionThrown;

		public void Start(){
			if (context == null) {
				context = new BackgroundLooper ();
				context.ExceptionThrown += Context_ExceptionThrown;
				OnExecutionStateChanged (ExecutionState.Executing);
				context.Start ();
			}
		}


		public void Pause(){
			if (context != null) {
				OnExecutionStateChanged (ExecutionState.Paused);

				DrainQueuedMethods ();

				context.Pause ();
			}
		}

		public void Resume(){
			if (context != null) {
				OnExecutionStateChanged (ExecutionState.Executing);

				context.Resume();
			}
		}

		public void Stop(){
			if (context != null) {

				OnExecutionStateChanged (ExecutionState.Stopping);

				context.Resume();

				DrainQueuedMethods ();

				OnExecutionStateChanged (ExecutionState.Stop);

				context.ExceptionThrown -= Context_ExceptionThrown;

				context.Dispose();

				context = null;
			}
		}

		void Context_ExceptionThrown (object sender, ThreadExceptionEventArgs e)
		{
			OnExceptionThrownEvent (e.Exception);
		}

		private void DrainQueuedMethods(){
			while (context.HasMessages) {
			}
		}

		private void AssertContext(){
			if (context == null)
				throw new Exception ("Rendering execution context is not created yet");
		}

		protected virtual void OnExecutionStateChanged(ExecutionState newState){

			if (newState == state) {
				return;
			}

			var oldState = state;
			state = newState;

			var executionStateChanged = ExecutionStateChanged;

			if (executionStateChanged != null) {
				executionStateChanged (this, new ExecutionStateChangedEventArgs (state, oldState));
			}
		}

		protected virtual void OnExceptionThrownEvent(Exception error){
			var exceptionThrown = ExceptionThrown;

			if (exceptionThrown != null) {
				exceptionThrown (this, new ThreadExceptionEventArgs (error));
			}
		}

		public IAsyncResult BeginInvoke(Delegate method, params object[] args){
			if (state == ExecutionState.Stop || state == ExecutionState.Stopping)
				return null;

			AssertContext ();
			return context.BeginInvoke (method, args);
		}

		public object Invoke(Delegate method, params object[] args)
		{
			if (state == ExecutionState.Stop || state == ExecutionState.Stopping)
				return null;

			AssertContext ();
			return context.Invoke (method, args);
		}

		public object EndInvoke(IAsyncResult result){
			AssertContext ();
			return context.EndInvoke (result);
		}

		public bool InvokeRequired{
			get{
				if (context == null)
					return false;
				else {
					return context.InvokeRequired;
				}
			}
		}

		public Thread Thread{
			get{
				if (context == null)
					return null;
				else
					return context.Thread;
			}
		}

		public ExecutionState State{
			get{
				return state;
			}
		}
	}


}

