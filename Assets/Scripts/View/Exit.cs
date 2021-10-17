using UnityEngine;

namespace RollAndBall
{
    public class Exit : MonoBehaviour
    {
        public GameObject _exit;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<PlayerBall>())
            {
                _exit.SetActive(false);
            }
        }
    }
}
