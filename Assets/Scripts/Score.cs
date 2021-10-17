using UnityEngine;

namespace RollAndBall
{
    public class Score : MonoBehaviour
    {
        private int _score = 0;       

        private void OnGUI()
        {
            GUI.Label(new Rect(10, 10, 100, 100), "Score: " + _score);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<Coin>())
            {
                _score++;
            }                   
        }
    }
}
