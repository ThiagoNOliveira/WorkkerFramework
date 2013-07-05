using Microsoft.Practices.Unity.InterceptionExtension;

namespace Workker.Framework.Domain.AOPException
{
    internal class LoggerAttribute : HandlerAttribute
    {
        public override ICallHandler CreateHandler(Microsoft.Practices.Unity.IUnityContainer container)
        {
            return new LoggerCallHandler();
        }
    }
}
