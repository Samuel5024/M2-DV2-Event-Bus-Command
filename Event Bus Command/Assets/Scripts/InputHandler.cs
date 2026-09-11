using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private Invoker _invoker;
    private bool _isReplaying;
    private bool _isRecording;
    private BikeController1 _bikeController1;
    private Command _buttonA, _buttonD, _buttonW;
    
    void Start()
    {
        _invoker = gameObject.AddComponent<Invoker>();
        _bikeController1 = FindObjectOfType<BikeController1>();

        _buttonA = new TurnLeft(_bikeController1);
        _buttonD = new TurnRight(_bikeController1);
        _buttonW = new ToggleTurbo(_bikeController1);
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
            _bikeController1.ResetPosition();
            _isReplaying = false;
            _isRecording = true;
            _invoker.Record();
        }

        if(GUILayout.Button("Stop Recording"))
        {
            _bikeController1.ResetPosition();
            _isRecording = false;
        }

        if(!_isRecording)
        {
            if(GUILayout.Button("Start Replay"))
            {
                _bikeController1.ResetPosition();
                _isRecording = false;
                _isReplaying = true;
                _invoker.Replay();
            }
        }
    }
}
