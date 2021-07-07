using System;
using System.Linq;
using System.Reflection;
using Castle.DynamicProxy;

using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.Aspects;

using Ninject.Infrastructure.Language;

namespace JanHoffmann.Red.CrossCutting.Core.NinjectAdapter.ExceptionMappingInterception
{
    public class ExceptionMapInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var interceptedType = invocation.TargetType;
            var interfaceWithMappingAttributes =
                interceptedType.GetInterfaces().FirstOrDefault(i => i.HasAttribute<ExceptionMapAttribute>());
            if (interfaceWithMappingAttributes != null)
            {
                var attribute = interfaceWithMappingAttributes.GetCustomAttribute<ExceptionMapAttribute>();
                var typeMessage = attribute.Message;
                var targetExceptionType = attribute.TypeToMapTo;

                try
                {
                    invocation.Proceed();
                }
                catch (Exception e) when (e.GetType() != targetExceptionType)
                {
                    var methodMessage = invocation.Method.GetCustomAttribute<ExceptionMessageAttribute>()?.Message;

                    if (methodMessage != null)
                    {
                        methodMessage = string.Format(methodMessage, invocation.Arguments);
                    }

                    var exceptionInstance = (Exception)Activator.CreateInstance(targetExceptionType, methodMessage ?? typeMessage, e);
                    throw exceptionInstance;
                }
            }
        }
    }
}
