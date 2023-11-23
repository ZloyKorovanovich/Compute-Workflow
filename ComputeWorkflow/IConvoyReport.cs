namespace ComputeWorkflow
{
    /// <summary>
    /// Recives report of convoy stage.
    /// </summary>
    public interface IConvoyReport
    {
        /// <summary>
        /// Convoy end stage.
        /// </summary>
        public void ReportConvoyEnd();
    }
}