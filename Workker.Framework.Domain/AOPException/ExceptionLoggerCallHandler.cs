using Microsoft.Practices.Unity.InterceptionExtension;

namespace Workker.Framework.Domain.AOPException
{
    internal class ExceptionLoggerCallHandler : ICallHandler
    {
        public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
        {
            IMethodReturn result = getNext()(input, getNext);
            if (result.Exception != null)
            {
                throw result.Exception;
            }

            return result;
        }

        public int Order { get; set; }
    }
}
