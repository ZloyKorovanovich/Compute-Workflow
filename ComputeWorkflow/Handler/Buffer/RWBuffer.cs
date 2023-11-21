using UnityEngine;

namespace ComputeWorkflow.Handler
{
    /// <summary>
    /// Responsible for operations on Read-Write ComputeBuffer.
    /// </summary>
    public abstract class RWBuffer : ShaderBuffer
    {
        protected ComputeBuffer _buffer;

        public RWBuffer(ComputeConvoy convoy, string name, int count, int stride) : base(convoy, name)
        {
            _buffer = new ComputeBuffer(count, stride);
        }

        public override void Dispose()
        {
            _buffer?.Release();
        }

        public override void ToCompute()
        {
            _convoy.Compute.SetBuffer(_convoy.KernelData.KernelId, _name, _buffer);
        }

        /// <summary>
        /// Reads data from ComputeBuffer after dispatching it.
        /// </summary>
        public abstract void ReadData();
    }
}