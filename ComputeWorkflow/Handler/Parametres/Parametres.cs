using UnityEngine;

namespace ComputeWorkflow.Handler
{
    /// <summary>
    /// Responsible for parametres assignable to ComputeShader.
    /// </summary>
    public abstract class Parametres : IComputeInput
    {
        protected ComputeShader _compute;

        /// <summary>
        /// Sets ComputeShader for assigning data.
        /// </summary>
        public void SetCompute(ComputeShader compute)
        {
            _compute = compute;
        }

        public abstract void ToCompute();
    }
}