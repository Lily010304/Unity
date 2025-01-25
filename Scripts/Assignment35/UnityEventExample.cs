using UnityEngine;
using UnityEngine.Events;
namespace assignment35
{
    public class UnityEventExample : MonoBehaviour
    {
        UnityEvent OnEventTriggered;
        void Start()
        {
            OnEventTriggered = new UnityEvent();
            OnEventTriggered.AddListener(OnEventResponse);
        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                OnEventTriggered.Invoke();
            }
        }
        void OnEventResponse() => Debug.Log("Event is triggered (space bar is pressed)!");
    }
}
