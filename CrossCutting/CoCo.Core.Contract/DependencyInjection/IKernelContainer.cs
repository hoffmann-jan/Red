namespace JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.DependencyInjection
{
    public interface IKernelContainer
    {
        ICoCoKernel Kernel { get; }
    }
}
