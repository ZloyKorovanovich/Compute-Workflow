using System.Collections.Generic;

namespace ComputeWorkflow
{
    /// <summary>
    /// Responsible for processing compute convoys.
    /// </summary>
    public static class ComputeProcessor
    {
        private static List<ComputeConvoy> _convoys;
        public static int ConvoyCount => _convoys.Count;

        static ComputeProcessor()
        {
            _convoys = new List<ComputeConvoy>();
        }

        /// <summary>
        /// Adds convoy to convoy list.
        /// </summary>
        public static void AddConvoy(ComputeConvoy convoy)
        {
            if(_convoys.Contains(convoy))
                _convoys.Add(convoy);
        }

        /// <summary>
        /// Ends convoy forcibly.
        /// </summary>
        public static void End(ComputeConvoy convoy)
        {
            _convoys[_convoys.IndexOf(convoy)].End();
            _convoys.Remove(convoy);
        }

        /// <summary>
        /// Ends forcibly all the convoys.
        /// </summary>
        public static void EndAll()
        {
            for (int i = 0; i < _convoys.Count; i++)
                _convoys[i].End();

            _convoys.Clear();
        }
    }
}