using Microsoft.Practices.Unity.InterceptionExtension;

namespace Workker.Framework.Domain
{
    public class ExceptionLoggerAttribute : HandlerAttribute
    {
        public override ICallHandler CreateHandler(Microsoft.Practices.Unity.IUnityContainer container)
        {
            return new ExceptionLoggerCallHandler();
        }
    }
}
