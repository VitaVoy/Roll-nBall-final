using UnityEngine;

namespace RollAndBall
{

    public class Teleport : MonoBehaviour
    {
        public bool isTeleported = false;
        public Teleport Target;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<PlayerBall>())
            {
                if (!isTeleported)
                {
                    Target.isTeleported = true;
                    other.transform.position = Target.transform.position;
                }
            }
        }

        
    }
}