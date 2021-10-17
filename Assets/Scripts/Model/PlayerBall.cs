using UnityEngine;

namespace RollAndBall
{   
    public sealed class PlayerBall : Player
    {
       
        private void FixedUpdate()
        {    
            Move();
            Jump();
        }                       
        public override void Start()
        {
            base.Start();

            Rigidbody.AddForce(Vector3.zero);
        }
        public void ChangeSpeed(float _speed)
        {
            Speed = _speed;
        }

    }
   
}
