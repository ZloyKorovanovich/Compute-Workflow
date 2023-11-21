using UnityEngine;

namespace ComputeWorkflow.Handler
{
    /// <summary>
    /// Responsible for parametres assignable to ComputeShader.
    /// </summary>
    public abstract class Parametres : ConvoyHandler, IComputeInput
    {
        protected Parametres(ComputeConvoy convoy) : base(convoy)
        {

        }

        public abstract void ToCompute();
    }
}