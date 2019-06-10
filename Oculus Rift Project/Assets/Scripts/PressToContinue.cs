using UnityEngine;
using UnityEngine.Events;

public class PressToContinue : MonoBehaviour
{
    [SerializeField]
    private UnityEvent customEvent;

    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Start))
        {
            Debug.Log("Start");
            customEvent?.Invoke();
        }
    }
}
