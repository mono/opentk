using System;
using System.ComponentModel;
using System.Threading;

namespace OpenTK.Platform.Android
{
	public interface IExecutionContext : ISynchronizeInvoke
	{
		event EventHandler<ExecutionStateChangedEventArgs> ExecutionStateChanged;

		Thread Thread{ get;}
		void Pause ();
		void Stop();
		void Resume();
		void Start ();

		ExecutionState State{ get;}
	}

	public class ExecutionStateChangedEventArgs : EventArgs{
		public ExecutionState State{ get; private set;}
		public ExecutionState OldState{ get; private set;}

		public ExecutionStateChangedEventArgs(ExecutionState state, ExecutionState oldState){
			this.State = state;
			this.OldState = oldState;
		}
	}

	public enum ExecutionState{
		Stop,
		Executing,
		Paused,
		Stopping
	}
}

