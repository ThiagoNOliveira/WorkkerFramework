using Microsoft.Practices.Unity.InterceptionExtension;

namespace Workker.Framework.Domain
{
    public class LoggerAttribute : HandlerAttribute
    {
        public override ICallHandler CreateHandler(Microsoft.Practices.Unity.IUnityContainer container)
        {
            return new LoggerCallHandler();
        }
    }
}
