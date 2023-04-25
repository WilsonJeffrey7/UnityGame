
using UnityEngine;

namespace Unity.FPS.Gameplay
{
    public class PositionBobbing : MonoBehaviour
    {
        public float VerticalBobFrequency = 1f;

        public float BobbingAmount = 0.5f;

        Vector3 m_StartPosition;

        void Start()
        {
            // Remember start position for animation
            m_StartPosition = transform.position;
        }

        void Update()
        {
            // Handle bobbing
            float bobbingAnimationPhase = ((Mathf.Sin(Time.time * VerticalBobFrequency) * 0.5f) + 0.5f) * BobbingAmount;
            transform.position = m_StartPosition + Vector3.up * bobbingAnimationPhase;
        }
    }
}