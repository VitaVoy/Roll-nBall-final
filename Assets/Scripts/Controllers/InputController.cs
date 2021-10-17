using UnityEngine;

namespace RollAndBall
{
    public class InputController : IExecute
    {
        private readonly Player _playerBase;
        private readonly InputData _inputData;
        private readonly ISaveDataRepository _saveDataRepository;
      
        public InputController(Player player, InputData inputData)
        {
            _saveDataRepository = new SaveDataRepository();
        }

        public void Execute()
        {            
            if (Input.GetKeyDown(_inputData.SavePlayer))
            {
                _saveDataRepository.Save(_playerBase);
            }
            if (Input.GetKeyDown(_inputData.LoadPlayer))
            {
                _saveDataRepository.Load(_playerBase);
            }           
        }
    }
}
