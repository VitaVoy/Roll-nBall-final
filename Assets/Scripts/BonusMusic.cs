using UnityEngine;

namespace RollAndBall
{
    public class BonusMusic : MonoBehaviour
    {
        public delegate void PlayMusic();
        public event PlayMusic _playMusic;

        private AudioSource _audioSource;        
        void Start()
        {
            _audioSource = GetComponent<AudioSource>();
            _playMusic += new PlayMusic(PlayBell);
        }

        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<Coin>()) _playMusic?.Invoke();
        }

        public void PlayBell()
        {
            _audioSource.Play();
        }
    }
}
