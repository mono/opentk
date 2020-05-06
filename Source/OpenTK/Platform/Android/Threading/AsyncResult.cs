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
using System.Threading;

namespace OpenTK.Platform.Android.Threading
{
    /// <summary>
    /// Provides basic implementation of the IAsyncResult interface.
    /// </summary>
    public class AsyncResult
        : IAsyncResult
        , IDisposable
    {
        #region AsyncResult Members

        #region Fields

        // A value indicating whether this AsyncResult object has been disposed.
        private bool disposed;

        // The owner of this AsyncResult object.
        private object owner;

        // The callback to be invoked when the operation completes.
        private AsyncCallback callback;

        // User state information.
        private object state;

        // For signaling when the operation has completed.
        private ManualResetEvent waitHandle;

        // A value indicating whether the operation completed synchronously.
        private bool completedSynchronously;

        // A value indicating whether the operation has completed.
        private bool isCompleted;

        // The ID of the thread this AsyncResult object originated on.
        private int threadId;

        #endregion

        #region Construction

        /// <summary>
        /// Initializes a new instance of the AsyncResult object with the
        /// specified owner of the AsyncResult object, the optional callback
        /// delegate, and optional state object.
        /// </summary>
        /// <param name="owner">
        /// The owner of the AsyncResult object.
        /// </param>
        /// <param name="callback">
        /// An optional asynchronous callback, to be called when the 
        /// operation is complete. 
        /// </param>
        /// <param name="state">
        /// A user-provided object that distinguishes this particular 
        /// asynchronous request from other requests. 
        /// </param>
        public AsyncResult(object owner, AsyncCallback callback, object state)
        {
            this.owner = owner;
            this.callback = callback;
            this.state = state;

            // Get the current thread ID. This will be used later to determine
            // if the operation completed synchronously.
            this.threadId = Thread.CurrentThread.ManagedThreadId;
            this.waitHandle = new ManualResetEvent(false);
        }

        #endregion

        /// <summary>
        /// The finalizer override method.
        /// </summary>
        ~AsyncResult()
        {
            Dispose(false);
        }

        #region Methods

        /// <summary>
        /// Signals that the operation has completed.
        /// </summary>
        public void Signal()
        {
            this.isCompleted = true;
            this.completedSynchronously = threadId == Thread.CurrentThread.ManagedThreadId;
            this.waitHandle.Set();

            if (callback != null)
            {
                callback(this);
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the owner of this AsyncResult object.
        /// </summary>
        public object Owner
        {
            get { return this.owner; }
        }

        #endregion

        #endregion

        #region IAsyncResult Members

        /// <summary>
        /// Gets a user-defined object that qualifies or contains information about an
        /// asynchronous operation.
        /// </summary>
        public object AsyncState
        {
            get { return this.state; }
        }

        /// <summary>
        /// Gets a System.Threading.WaitHandle that is used to wait for an asynchronous
        /// operation to complete.
        /// </summary>
        public WaitHandle AsyncWaitHandle
        {
            get { return this.waitHandle; }
        }

        /// <summary>
        /// Gets an indication of whether the asynchronous operation completed synchronously.
        /// </summary>
        public bool CompletedSynchronously
        {
            get { return this.completedSynchronously; }
        }

        /// <summary>
        /// Gets an indication whether the asynchronous operation has completed.
        /// </summary>
        public bool IsCompleted
        {
            get { return this.isCompleted; }
        }

        #endregion

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
                    this.waitHandle.Close();
                }

                disposed = true;
            }
        }

        #region IDisposable Members

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or
        /// resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}