using UnityEngine;

namespace ComputeWorkflow.Handler
{
    /// <summary>
    /// Responsible for operations on ComputeBuffers and RenderTextures.
    /// </summary>
    public abstract class ShaderBuffer : ConvoyHandler, IComputeInput
    {
        protected string _name;

        public ShaderBuffer(ComputeConvoy convoy, string name) : base(convoy)
        {
            _name = name;
        }

        /// <summary>
        /// Releases Buffer or RenderTexture avoiding leak of memory.
        /// </summary>
        public abstract void Dispose();
        public abstract void ToCompute();
    }
}

