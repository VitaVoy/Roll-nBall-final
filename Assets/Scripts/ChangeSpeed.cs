using UnityEngine;

namespace RollAndBall
{
    public class ChangeSpeed : MonoBehaviour
    {
        [SerializeField]
        private float _speed;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<PlayerBall>())
            {
                other.GetComponent<PlayerBall>().ChangeSpeed(_speed);
            }
        }
    }
}
