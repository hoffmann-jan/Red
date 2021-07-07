﻿using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.DependencyInjection;

using Ninject;

namespace JanHoffmann.Red.CrossCutting.Core.NinjectAdapter
{
    public class KernelContainer : IKernelContainer
    {
        private static ICoCoKernel _innerKernel;
        private static readonly object _lock = new object();

        public ICoCoKernel Kernel
        {
            get
            {
                lock (_lock)
                {
                    if (_innerKernel == null)
                    {
                        _innerKernel = new KernelAdapter(new StandardKernel());
                        _innerKernel.Register<ICoCoKernel, KernelAdapter>();
                    }

                    return _innerKernel;
                }
            }
        }
    }
}
