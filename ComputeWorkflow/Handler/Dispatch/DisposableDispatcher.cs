using ComputeWorkflow.Kernel;

namespace ComputeWorkflow.Handler
{
    /// <summary>
    /// Dispatcher that forcibly ends convoy after Dispatch() method;
    /// </summary>
    public class DisposableDispatcher : Dispatcher
    {
        public DisposableDispatcher(ComputeConvoy convoy, KernelData kernelData) : base(convoy, convoy.Compute, kernelData)
        {

        }

        /// <summary>
        /// Dispatches ComputeShader and ends convoy.
        /// </summary>
        public override void Dispatch(int xThread, int yThread, int zThread)
        {
            base.Dispatch(xThread, yThread, zThread);
            ComputeProcessor.End(_convoy);
        }
    }
}