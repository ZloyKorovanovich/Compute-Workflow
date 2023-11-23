using UnityEngine;
using ComputeWorkflow.Handler;
using ComputeWorkflow.Kernel;

namespace ComputeWorkflow
{
    /// <summary>
    /// Responsible for any of operations on ComputeShaders using Handlers of workflow.
    /// </summary>
    public abstract class ComputeConvoy
    {
        protected ComputeShader _compute;
        protected KernelData _kernelData;

        public ComputeShader Compute => _compute;
        public KernelData KernelData => _kernelData;

        protected Dispatcher _dispatcher;

        public ComputeConvoy(ComputeShader compute, string kernelName)
        {
            _compute = compute;
            KernelInfo.ReadKernelData(_compute, kernelName, out _kernelData);
            InitDispatcher();

            ComputeProcessor.AddConvoy(this);
        }

        /// <summary>
        /// Processes all the operations and dispatching forcibly.
        /// </summary>
        public virtual void ProcessImmediately()
        {
            ParametresToCompute();
            InitBuffers();
            BuffersToCompute();

            Dispatch();
        }

        /// <summary>
        /// Makes final operations before dispatching and dispatches Compute Shader.
        /// </summary>
        protected virtual void Dispatch()
        {
            _dispatcher.Dispatch(_kernelData.XSize, _kernelData.YSize, _kernelData.ZSize);
        }

        /// <summary>
        /// Initializes Dispatcher class, responsable for dispatching Compute Shader.
        /// </summary>
        protected virtual void InitDispatcher()
        {
            _dispatcher = new Dispatcher(this, _compute, _kernelData);
        }

        /// <summary>
        /// Ends convoy safely.
        /// </summary>
        public abstract void End();

        /// <summary>
        /// Sets parametres to Compute Shader.
        /// </summary>
        protected abstract void ParametresToCompute();

        /// <summary>
        /// Sets buffers to Compute Shader.
        /// </summary>
        protected abstract void BuffersToCompute();

        /// <summary>
        /// Initializes ShaderBuffer class(es), responsable for operations on ComputeBuffers and RenderTextures.
        /// </summary>
        protected abstract void InitBuffers();
    }
}