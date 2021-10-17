using UnityEngine;

namespace RollAndBall
{    
    public class GameOver : MonoBehaviour
    {
        public GameObject YouLose;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<PlayerBall>())
            {
                YouLose.SetActive(true);                    
            }
        }
    }
}
