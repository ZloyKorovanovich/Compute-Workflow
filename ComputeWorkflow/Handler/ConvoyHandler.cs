namespace ComputeWorkflow.Handler
{
    /// <summary>
    /// Any handler related to convoy.
    /// </summary>
    public abstract class ConvoyHandler
    {
        protected ComputeConvoy _convoy;

        public ConvoyHandler(ComputeConvoy convoy)
        {
            _convoy = convoy;
        }
    }
}