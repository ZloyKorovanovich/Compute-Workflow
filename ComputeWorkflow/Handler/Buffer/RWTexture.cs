using UnityEngine;

namespace ComputeWorkflow.Handler
{
    /// <summary>
    /// Responsible for operations on Read-Write RenderTextrue.
    /// </summary>
    public abstract class RWTexture : ShaderBuffer
    {
        protected RenderTexture _texture;

        public RWTexture(ComputeConvoy convoy, string name, RenderTexture texture) : base(convoy, name)
        {
            _texture = texture;
        }

        public override void Dispose()
        {
            _texture?.Release();
        }

        public override void ToCompute()
        {
            _convoy.Compute.SetTexture(_convoy.KernelData.KernelId, _name, _texture);
        }
    }
}