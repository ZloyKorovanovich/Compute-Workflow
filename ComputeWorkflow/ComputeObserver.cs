using UnityEngine;

namespace ComputeWorkflow
{
    public class ComputeObserver : MonoBehaviour
    {
        private void OnDisable()
        {
            ComputeProcessor.EndAll();
        }
    }
}