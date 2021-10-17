using UnityEngine;
using random = UnityEngine.Random; 

namespace RollAndBall
{

    public sealed class Coin : InteractiveObject, IFlicker, IFly, IRotation
    {
        [SerializeField]
        private GameObject _coinPrefab;

        private Material _material;
        private float _flyHeight;        

        private void Awake()
        {
            _material = GetComponent<Renderer>().material;
            _flyHeight = random.Range(2.0f, 6.0f);           
        }      
        
        private void Update()
        {
            Rotation();
            Fly();
            Flicker();
        }        
        protected override void Interaction()
        {            
        }

        public void Flicker()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b, Mathf.PingPong(Time.time, 1.0f));
        }

        public void Fly()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,
                                                    Mathf.PingPong(Time.time, _flyHeight),
                                                    transform.localPosition.z);
        }

        public void Rotation()
        {
            transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
        }        
    }   
}

