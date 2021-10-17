using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace RollAndBall
{
    public class ButtonRestart : MonoBehaviour
    {
        [SerializeField]
        private GameObject YouLose;
        [SerializeField]
        private Button _restartButton;

        private void Start()
        {
            _restartButton.onClick.AddListener(Restart);
        }

        private void Restart()
        {
            YouLose.SetActive(false);
            SceneManager.LoadScene("MainScene");
        }
    }
}
