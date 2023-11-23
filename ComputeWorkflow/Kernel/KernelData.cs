namespace ComputeWorkflow.Kernel
{
    /// <summary>
    /// Includes info about Kernel in ComputeShader.
    /// </summary>
    public struct KernelData
    {
        public int KernelId;

        public int XSize;
        public int YSize;
        public int ZSize;

        public KernelData(int kernelId, int xSize,  int ySize, int zSize)
        {
            KernelId = kernelId;

            XSize = xSize;
            YSize = ySize;
            ZSize = zSize;
        }
    }
}