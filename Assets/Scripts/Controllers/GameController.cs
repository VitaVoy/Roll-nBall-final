using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollAndBall
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private InputData _inputData;
        public PlayerType PlayerType = PlayerType.Ball;
        private ListExecuteObject _interactiveObject;
        private CameraController _cameraController;
        private InputController _inputController;
        private int _countBonuses;
        private Reference _reference;

        private void Awake()
        {
            _reference = new Reference();

            Player player = null;
            if (PlayerType == PlayerType.Ball)
            {
                player = _reference.PlayerBall;
            }

            _cameraController = new CameraController(player.transform, _reference.MainCamera.transform);
            _interactiveObject.AddExecuteObject(_cameraController);
        }
    }
}
