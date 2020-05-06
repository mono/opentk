#region License

/* Copyright (c) 2006 Leslie Sanford
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy 
 * of this software and associated documentation files (the "Software"), to 
 * deal in the Software without restriction, including without limitation the 
 * rights to use, copy, modify, merge, publish, distribute, sublicense, and/or 
 * sell copies of the Software, and to permit persons to whom the Software is 
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in 
 * all copies or substantial portions of the Software. 
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN 
 * THE SOFTWARE.
 */

#endregion

#region Contact

/*
 * Leslie Sanford
 * Email: jabberdabber@hotmail.com
 */

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Threading;


namespace OpenTK.Platform.Android.Threading
{
	/// <summary>
	/// Represents an asynchronous queue of delegates.
	/// </summary>
	public class BackgroundLooper
		: SynchronizationContext
	, ISynchronizeInvoke
	{
		#region Constants
		private const string OBJECT_DISPOSED_EXCEPTION = "Object already disposed";
		#endregion


		#region DelegateQueue Members

		#region Fields

		// The thread for processing delegates.
		private readonly Thread delegateThread;

		// The queue for holding delegates.
		private readonly Queue<DelegateQueueAsyncResult> delegateQueue;

		// The object to use for locking.
		private readonly object lockObject;

		// Indicates whether the delegate queue has been disposed.
		private volatile bool disposed;

		// Indicates whether the DelegateQueue is in the process of disposal.
		private volatile bool disposing;

		// Thread ID counter for all DelegateQueues.
		private static volatile uint threadID = 0;


		private event EventHandler<ThreadExceptionEventArgs> ExceptionThrownEvent;
		private event EventHandler DisposedEvent;

		#endregion

		#region Events

		/// <summary>
		/// Occurs when an exception is raised while executing some delegate
		/// in the context of this DelegateQueue.
		/// </summary>
		public event EventHandler<ThreadExceptionEventArgs> ExceptionThrown
		{
			add
			{
				if (disposed)
				{
					throw new ObjectDisposedException(string.Empty, OBJECT_DISPOSED_EXCEPTION);
				}
				this.ExceptionThrownEvent += value;
			}
			remove { this.ExceptionThrownEvent -= value; }
		}

		#endregion

		#region Construction

		/// <summary>
		/// Initializes a new instance of the DelegateQueue class.
		/// </summary>
		public BackgroundLooper()
			: this(0)
		{
		}

		/// <summary>
		/// Initializes a new instance of the DelegateQueue class.
		/// </summary>
		/// <param name="maxStackSize">
		/// The maximum stack size to be used by the DelegateQueue
		/// thread, or 0 to use the default maximum stack size specified in the
		/// header for the executable.
		/// </param>
		public BackgroundLooper(int maxStackSize)
		{
			// Create thread for processing delegates.
			delegateThread = new Thread(DelegateProcedure, maxStackSize);
			delegateThread.IsBackground = true;
			delegateQueue = new Queue<DelegateQueueAsyncResult>();
			lockObject = new object();
		}

		/// <summary>
		/// The finalizer override method.
		/// </summary>
		~BackgroundLooper()
		{
			Dispose(false);
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets a unique identifier for the managed thread
		/// on which this DelegateQueue is
		/// executing.
		/// </summary>
		public int ManagedThreadId
		{
			get { return this.delegateThread.ManagedThreadId; }
		}

		/// <summary>
		/// Gets a value indicating whether this DelegateQueue
		/// is in the process of disposal.
		/// </summary>
		public bool Disposing
		{
			get { return this.disposing; }
		}

		/// <summary>
		/// Gets or sets the culture for the delegate queue thread.
		/// </summary>
		public CultureInfo CurrentCulture
		{
			get { return this.delegateThread.CurrentCulture; }
			set { this.delegateThread.CurrentCulture = value; }
		}

		/// <summary>
		/// Gets or sets the current culture used by the Resource Manager to look up
		/// culture-specific resources at run time.
		/// </summary>
		public CultureInfo CurrentUICulture
		{
			get { return this.delegateThread.CurrentUICulture; }
			set { this.delegateThread.CurrentUICulture = value; }
		}

		/// <summary>
		/// Returns an System.Threading.ApartmentState value indicating the apartment state.
		/// </summary>
		/// <returns>
		/// One of the System.Threading.ApartmentState values indicating the apartment
		/// state of the delegate queue's managed thread. The default is
		/// System.Threading.ApartmentState.Unknown.
		/// </returns>
		public ApartmentState GetApartmentState()
		{
			return this.delegateThread.GetApartmentState();
		}

		/// <summary>
		/// Sets the apartment state of a delegate queue's thread before it is started.
		/// </summary>
		/// <param name="state">The new apartment state.</param>
		public void SetApartmentState(ApartmentState state)
		{
			this.delegateThread.SetApartmentState(state);
		}

		/// <summary>
		/// Sets the apartment state of a delegate queue's thread before it is started.
		/// </summary>
		/// <param name="state">The new apartment state.</param>
		/// <returns>True if the apartment state is set; otherwise, false.</returns>
		public bool TrySetApartmentState(ApartmentState state)
		{
			return this.delegateThread.TrySetApartmentState(state);
		}

		/// <summary>
		/// Gets or sets a value indicating the scheduling priority of the
		/// delegate queue's thread.
		/// </summary>
		public ThreadPriority Priority
		{
			get { return this.delegateThread.Priority; }
			set { this.delegateThread.Priority = value; }
		}

		#endregion

		#region Methods

		/// <summary>
		/// Sets the preferred processor for the delegate queue's
		/// system thread to run on. This method is executed
		/// asynchronously as soon as possible.
		/// </summary>
		/// <param name="processorIndex">
		/// The zero-based processor index specifying the delegate
		/// queue's ideal processor.
		/// </param>


		/// <summary>
		/// Starts delegate execution in the delegate queue.
		/// </summary>
		public void Start()
		{
			if (disposed)
			{
				throw new ObjectDisposedException(string.Empty, OBJECT_DISPOSED_EXCEPTION);
			}

			if (delegateThread.IsAlive)
			{
				throw new InvalidOperationException();
			}

			lock (lockObject)
			{
				// Increment to next thread ID.
				threadID++;

				// Create name for thread.
				delegateThread.Name = "Delegate Queue Thread: Id[" + threadID + "] ";

				// Start thread.
				delegateThread.Start();

				Debug.WriteLine(delegateThread.Name + " Started.");

				// Wait for signal from thread that it is running.
				Monitor.Wait(lockObject);
			}
		}

		public void Pause()
		{
			if (disposed)
			{
				throw new ObjectDisposedException(string.Empty, OBJECT_DISPOSED_EXCEPTION);
			}

			if (!Monitor.IsEntered (lockObject)) {
				Monitor.Enter (lockObject);
			}
		}

		/// <summary>
		/// Resumes delegate execution in the delegate queue.
		/// </summary>
		public void Resume()
		{
			if (disposed)
			{
				throw new ObjectDisposedException(string.Empty, OBJECT_DISPOSED_EXCEPTION);
			}

			if(Monitor.IsEntered(lockObject)){
				Monitor.Exit (lockObject);
			}
		}

		// Processes and invokes delegates.
		private void DelegateProcedure()
		{
			lock (lockObject)
			{
				// Signal the constructor that the thread is now running.
				Monitor.Pulse(lockObject);
			}

			// Set this DelegateQueue as the SynchronizationContext for this thread.
			SetSynchronizationContext(this);

			// Placeholder for DelegateQueueAsyncResult objects.
			DelegateQueueAsyncResult result = null;

			// While the DelegateQueue is not in the process
			// of being disposed (i.e. disposing).
			while (true)
			{
				// Critical section.
				lock (lockObject)
				{
					if (disposing)
					{
						break;
					}

					// If there are delegates waiting to be invoked.
					if (delegateQueue.Count > 0)
					{
						result = delegateQueue.Dequeue();
					}
					// Else there are no delegates waiting to be invoked.
					else
					{
						// Wait for next delegate.
						Monitor.Wait(lockObject);

						if (delegateQueue.Count > 0)
						{
							result = delegateQueue.Dequeue();
						}
						else continue;
					}
				}

				System.Diagnostics.Debug.Assert(result != null);

				try
				{
					// Invoke the delegate.
					result.Invoke();
				}
				catch (TargetInvocationException e)
				{
					OnExceptionThrown (e);
				}
			}

			OnDisposed(EventArgs.Empty);
			lock (lockObject)
			{
				while (delegateQueue.Count > 0)
				{
					result = delegateQueue.Dequeue();
					result.Abort();
				}

				this.DisposedEvent = null;
				this.ExceptionThrownEvent = null;
				this.disposed = true;
			}
			Debug.WriteLine(delegateThread.Name + " Finished");
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or
		/// resetting unmanaged resources.
		/// </summary>
		/// <param name="disposing">Indicates whether Dispose was called explicitly.</param>
		protected virtual void Dispose(bool disposing)
		{
			if (!disposed)
			{
				if (disposing)
				{
					lock (lockObject)
					{
						this.disposing = true;
						Monitor.Pulse(lockObject);
					}
				}
			}
		}

		/// <summary>
		/// Raises the Disposed event.
		/// </summary>
		/// <param name="e">The arguments to the event.</param>
		protected virtual void OnDisposed(EventArgs e)
		{
			EventHandler disposedEvent = DisposedEvent;
			if (disposedEvent != null)
			{
				disposedEvent(this, e);
			}
		}

		protected virtual void OnExceptionThrown(TargetInvocationException ex){
			var exceptionThrownEvent = ExceptionThrownEvent;

			if (exceptionThrownEvent != null)
			{
				exceptionThrownEvent(this, new ThreadExceptionEventArgs(ex.InnerException));
			}
		}

		#endregion

		#endregion

		#region SynchronizationContext Overrides

		/// <summary>
		/// Dispatches a synchronous message to this synchronization context. 
		/// </summary>
		/// <param name="d">
		/// The SendOrPostCallback delegate to call.
		/// </param>
		/// <param name="state">
		/// The object passed to the delegate.
		/// </param>
		/// <remarks>
		/// The Send method starts an synchronous request to send a message. 
		/// </remarks>
		public override void Send(SendOrPostCallback d, object state)
		{
			Invoke(d, state);
		}

		/// <summary>
		/// Dispatches an asynchronous message to this synchronization context. 
		/// </summary>
		/// <param name="d">
		/// The SendOrPostCallback delegate to call.
		/// </param>
		/// <param name="state">
		/// The object passed to the delegate.
		/// </param>
		/// <remarks>
		/// The Post method starts an asynchronous request to post a message. 
		/// </remarks>
		public override void Post(SendOrPostCallback d, object state)
		{
			if (d == null)
			{
				throw new ArgumentNullException("d", new System.ArgumentNullException("d"));
			}

			lock (lockObject)
			{
				if (disposed)
				{
					throw new ObjectDisposedException(string.Empty, OBJECT_DISPOSED_EXCEPTION);
				}

				delegateQueue.Enqueue(new DelegateQueueAsyncResult(this, d, new object[] { state }));
				Monitor.Pulse(lockObject);
			}
		}

		#endregion

		#region IComponent Members

		/// <summary>
		/// Represents the method that handles the Disposed delegate of a DelegateQueue.
		/// </summary>
		public event EventHandler Disposed
		{
			add
			{
				if (disposed)
				{
					throw new ObjectDisposedException(string.Empty, OBJECT_DISPOSED_EXCEPTION);
				}
				this.DisposedEvent += value;
			}
			remove { this.DisposedEvent -= value; }
		}



		#endregion

		#region ISynchronizeInvoke Members

		/// <summary>
		/// Executes the delegate on the main thread that this DelegateQueue executes on.
		/// </summary>
		/// <param name="method">
		/// A Delegate to a method that takes parameters of the same number and type that 
		/// are contained in args. 
		/// </param>
		/// <param name="args">
		/// An array of type Object to pass as arguments to the given method. This can be 
		/// a null reference (Nothing in Visual Basic) if no arguments are needed. 
		/// </param>
		/// <returns>
		/// An IAsyncResult interface that represents the asynchronous operation started 
		/// by calling this method.
		/// </returns>
		/// <remarks>
		/// <para>The delegate is called asynchronously, and this method returns immediately. 
		/// You can call this method from any thread. If you need the return value from a process 
		/// started with this method, call EndInvoke to get the value.</para>
		/// <para>If you need to call the delegate synchronously, use the Invoke method instead.</para>
		/// </remarks>
		public IAsyncResult BeginInvoke(Delegate method, params object[] args)
		{
			if (method == null)
			{
				throw new ArgumentNullException("method", OBJECT_DISPOSED_EXCEPTION);
			}

			DelegateQueueAsyncResult result = new DelegateQueueAsyncResult(this, method, args);
			lock (lockObject)
			{
				if (disposed)
				{
					throw new ObjectDisposedException(string.Empty, OBJECT_DISPOSED_EXCEPTION);
				}

				delegateQueue.Enqueue(result);
				Monitor.Pulse(lockObject);
			}
			return result;
		}

		/// <summary>
		/// Waits until the process started by calling BeginInvoke completes, and then returns 
		/// the value generated by the process.
		/// </summary>
		/// <param name="result">
		/// An IAsyncResult interface that represents the asynchronous operation started 
		/// by calling BeginInvoke. 
		/// </param>
		/// <returns>
		/// An Object that represents the return value generated by the asynchronous operation.
		/// </returns>
		/// <remarks>
		/// This method gets the return value of the asynchronous operation represented by the 
		/// IAsyncResult passed by this interface. If the asynchronous operation has not completed,
		/// this method will wait until the result is available.
		/// </remarks>
		public object EndInvoke(IAsyncResult result)
		{
			if (disposed)
			{
				throw new ObjectDisposedException(string.Empty, OBJECT_DISPOSED_EXCEPTION);
			}

			DelegateQueueAsyncResult asyncResult = result as DelegateQueueAsyncResult;
			if (asyncResult == null || asyncResult.Owner != this)
			{
				throw new ArgumentException("Invalid argument", "result");
			}

			asyncResult.AsyncWaitHandle.WaitOne();
			if (asyncResult.Exception != null)
			{
				throw asyncResult.Exception;
			}
			return asyncResult.ReturnValue;
		}

		/// <summary>
		/// Executes the delegate on the main thread that this DelegateQueue executes on.
		/// </summary>
		/// <param name="method">
		/// A Delegate that contains a method to call, in the context of the thread for the DelegateQueue.
		/// </param>
		/// <param name="args">
		/// An array of type Object that represents the arguments to pass to the given method.
		/// </param>
		/// <returns>
		/// An Object that represents the return value from the delegate being invoked, or a 
		/// null reference (Nothing in Visual Basic) if the delegate has no return value.
		/// </returns>
		/// <remarks>
		/// <para>Unlike BeginInvoke, this method operates synchronously, that is, it waits until 
		/// the process completes before returning. Exceptions raised during the call are propagated 
		/// back to the caller.</para>
		/// <para>Use this method when calling a method from a different thread to marshal the call 
		/// to the proper thread.</para>
		/// </remarks>
		public object Invoke(Delegate method, params object[] args)
		{
			if (method == null)
			{
				throw new ArgumentNullException("method");
			}

			if (InvokeRequired)
			{
				DelegateQueueAsyncResult result = new DelegateQueueAsyncResult(this, method, args);
				lock (lockObject)
				{
					if (disposed)
					{
						throw new ObjectDisposedException(string.Empty, OBJECT_DISPOSED_EXCEPTION);
					}

					delegateQueue.Enqueue(result);
					Monitor.Pulse(lockObject);
				}
				return EndInvoke(result);
			}
			// Invoke the method here rather than placing it in the queue.
			return method.DynamicInvoke(args);
		}

		/// <summary>
		/// Gets a value indicating whether the caller must call Invoke.
		/// </summary>
		/// <value>
		/// <b>true</b> if the caller must call Invoke; otherwise, <b>false</b>.
		/// </value>
		/// <remarks>
		/// This property determines whether the caller must call Invoke when making 
		/// method calls to this DelegateQueue. If you are calling a method from a different 
		/// thread, you must use the Invoke method to marshal the call to the proper thread.
		/// </remarks>
		public bool InvokeRequired
		{
			get
			{
				return Thread.CurrentThread.ManagedThreadId != delegateThread.ManagedThreadId;
			}
		}

		public int QueuedCount{
			get{
				lock (lockObject) {
					return this.delegateQueue.Count;
				}
			}
		}

		public bool HasMessages{
			get{
				return QueuedCount > 0;
			}
		}

		public Thread Thread{
			get{
				return delegateThread;
			}
		}

		#endregion

		#region IDisposable Members

		/// <summary>
		/// Disposes of the DelegateQueue.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		#endregion
	}
}