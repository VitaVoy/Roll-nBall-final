using UnityEngine;

namespace RollAndBall
{
    public class MiniMapCode : MonoBehaviour
    {
        public Transform PlayerTransform;

        private void LateUpdate()
        {
            UpdateCameraPosition();
        }

        void UpdateCameraPosition()
        {
            Vector3 NewPosition = PlayerTransform.position;
            NewPosition.y = transform.position.y;
            transform.position = NewPosition;
        }

    }
}
