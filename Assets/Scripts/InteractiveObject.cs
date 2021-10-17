using UnityEngine;

namespace RollAndBall
{
    public abstract class InteractiveObject : MonoBehaviour
    {
        protected abstract void Interaction();

        public bool isInteractable { get; } = true;

        private string Player = nameof(Player);

        private void OnTriggerEnter(Collider other)
        {
            if (!isInteractable || !other.gameObject.GetComponent<PlayerBall>())
            {
                return;
            }

            Destroy(gameObject);
        }
    }
}
