using System;

namespace OpenTK.Platform.Android.Threading
{
    /// <summary>
    /// Implements the IAsyncResult interface for the DelegateQueue class.
    /// </summary>
    internal class DelegateQueueAsyncResult
        : AsyncResult
    {
        // The delegate to be invoked.
        private Delegate method;

        // Args to be passed to the delegate.
        private object[] args;

        // The object returned from the delegate.
        private object returnValue = null;

        // Represents a possible exception thrown by invoking the method.
        private Exception exception = null;

        public DelegateQueueAsyncResult(
            object owner,
            Delegate method,
            object[] args)
            : base(owner, null, null)
        {
            this.method = method;
            this.args = args;
        }

        public void Invoke()
        {
            try
            {
                returnValue = method.DynamicInvoke(args);
            }
            catch (Exception e)
            {
                exception = e;
                throw;
            }
            finally
            {
                Signal();
            }
        }

        public void Abort()
        {
            exception = new OperationCanceledException();
            Signal();
        }

        public object ReturnValue
        {
            get { return returnValue; }
        }

        public Exception Exception
        {
            get { return exception; }
        }
    }
}
