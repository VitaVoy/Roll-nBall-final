using UnityEngine;

namespace RollAndBall
{
    [CreateAssetMenu(menuName = "Data/Input", fileName = "InputData")]
    public sealed class InputData : ScriptableObject
    {
        public KeyCode SavePlayer = KeyCode.C;
        public KeyCode LoadPlayer = KeyCode.V;
    }
}
