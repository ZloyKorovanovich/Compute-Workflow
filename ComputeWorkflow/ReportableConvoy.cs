using UnityEngine;

namespace ComputeWorkflow
{
    /// <summary>
    /// ComputeConvoy with opportunity to report stage.
    /// </summary>
    public abstract class ReportableConvoy : ComputeConvoy
    {
        private IConvoyReport _report;

        protected ReportableConvoy(ComputeShader compute, string kernelName, IConvoyReport report) : base(compute, kernelName)
        {

        }

        public override void End()
        {
            _report.ReportConvoyEnd();
        }
    }
}