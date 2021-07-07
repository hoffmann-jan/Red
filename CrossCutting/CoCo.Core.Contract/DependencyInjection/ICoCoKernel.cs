using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.Bootstrapping;
using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.DependencyInjection.DataClasses;

using System;

namespace JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.DependencyInjection
{
    public interface ICoCoKernel
    {
        void Register<TComponentContract, TComponentImplementation>(RegisterScope scope = RegisterScope.PerInject)
            where TComponentImplementation : TComponentContract;

        void Register(Type contract, Type implementation, RegisterScope scope = RegisterScope.PerInject);

        void RegisterToSelf<TComponentImplementation>(RegisterScope scope = RegisterScope.PerInject);

        void RegisterComponent<TComponent>()
            where TComponent : IComponentActivator;

        TContract Get<TContract>();
        TContract Get<TContract>(params ConstructorParameter[] parameters);

        object Get(Type contractType);
        object Get(Type contractType, params ConstructorParameter[] parameters);

        void RegisterConfiguration<T>();
    }
}
