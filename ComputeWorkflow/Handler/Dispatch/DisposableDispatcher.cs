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
        public override void Dispatch()
        {
            base.Dispatch();
            ComputeProcessor.End(_convoy);
        }
    }
}