using UnityEngine;

namespace RollAndBall
{
    public abstract class Player : MonoBehaviour
    {
        public float Speed = 5.0f;
        public Rigidbody Rigidbody;             

        public virtual void Start()
        {
            Rigidbody = GetComponent<Rigidbody>();
        }

        protected void Move()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal * -1, 0.0f, moveVertical * -1);

            Rigidbody.AddForce(movement * Speed);
        }

        protected void Jump()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<Rigidbody>().AddForce(new Vector3(0, 500, 0));
            }
        }
    }
}
