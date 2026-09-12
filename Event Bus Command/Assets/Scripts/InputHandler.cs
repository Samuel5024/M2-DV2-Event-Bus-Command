using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private Invoker _invoker;
    private bool _isReplaying;
    private bool _isRecording;
    private MotorBikeController _MotorBikeController;
    private Command _buttonA, _buttonD, _buttonW;
    
    void Start()
    {
        _invoker = gameObject.AddComponent<Invoker>();
        _MotorBikeController = FindObjectOfType<MotorBikeController>();

        _buttonA = new TurnLeft(_MotorBikeController);
        _buttonD = new TurnRight(_MotorBikeController);
        _buttonW = new ToggleTurbo(_MotorBikeController);
    }

    void Update()
    {
        if(!_isReplaying && _isRecording)
        {
            if(Input.GetKeyUp(KeyCode.A))
            {
                _invoker.ExecuteCommand(_buttonA);
            }
            if(Input.GetKeyUp(KeyCode.D))
            {
                _invoker.ExecuteCommand(_buttonD);
            }
            if(Input.GetKeyUp(KeyCode.W))
            {
                _invoker.ExecuteCommand(_buttonW);
            }
        }
    }

    void OnGUI()
    {
        if(GUILayout.Button("Start Recording"))
        {
            _MotorBikeController.ResetPosition();
            _isReplaying = false;
            _isRecording = true;
            _invoker.Record();
        }

        if(GUILayout.Button("Stop Recording"))
        {
            _MotorBikeController.ResetPosition();
            _isRecording = false;
        }

        if(!_isRecording)
        {
            if(GUILayout.Button("Start Replay"))
            {
                _MotorBikeController.ResetPosition();
                _isRecording = false;
                _isReplaying = true;
                _invoker.Replay();
            }
        }
    }
}
