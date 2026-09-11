using UnityEngine;

namespace Chapter.EventBus
{
    public class ClientEventBus : MonoBehaviour
    {
        private bool _isButtonEnabled;

        void Start()
        {
            gameObject.AddComponent<HUDController>();
            gameObject.AddComponent<CountdownTimer>();
            gameObject.AddComponent<BikeController>();

            _isButtonEnabled = true;
        }
    }
}

