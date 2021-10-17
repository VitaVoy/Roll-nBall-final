using UnityEngine;

namespace RollAndBall
{

    public class Victory : MonoBehaviour
    {
        public GameObject YouWin;
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<PlayerBall>())
            {
                YouWin.SetActive(true);
            }
        }
    }
}
