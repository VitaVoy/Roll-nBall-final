using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace RollAndBall
{
    public class ButtonNextLevel : MonoBehaviour
    {
        [SerializeField]
        private GameObject YouWin;
        [SerializeField]
        private Button _nextLevelButton;

        private void Start()
        {
            _nextLevelButton.onClick.AddListener(Restart);
        }

        private void Restart()
        {
            YouWin.SetActive(false);
            SceneManager.LoadScene("MainScene");
        }
    }
}
