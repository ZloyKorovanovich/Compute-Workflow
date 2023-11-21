using UnityEngine;

namespace ComputeWorkflow.Kernel
{
    /// <summary>
    /// Responsible for reading Kernel infornmation from ComputeShader.
    /// </summary>
    public static class KernelInfo
    {
        /// <summary>
        /// Recives KernelData from ComputeShader.
        /// </summary>
        public static void ReadKernelData(ComputeShader compute, string kernelName, out KernelData kernelData)
        {
            int kernelId = compute.FindKernel(kernelName);
            compute.GetKernelThreadGroupSizes(kernelId, out uint x, out uint y, out uint z);
            kernelData = new KernelData(kernelId, (int)x, (int)y, (int)z);
        }
    }
}