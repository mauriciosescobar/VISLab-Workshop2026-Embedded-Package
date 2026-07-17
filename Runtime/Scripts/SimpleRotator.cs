using UnityEngine;

namespace VISLab.Workshop
{
    public class SimpleRotator : MonoBehaviour
    {
        [SerializeField] private float rotationSpeeed;

        void Update()
        {
            transform.Rotate(Vector3.up * rotationSpeeed * Time.deltaTime);
        }
    }
}