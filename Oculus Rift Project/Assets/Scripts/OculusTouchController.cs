using UnityEngine;

public class OculusTouchController : MonoBehaviour
{
    [SerializeField]
    private Transform touchControllerLeft;

    [SerializeField]
    private Transform touchControllerRight;

    void Update()
    {
        if (OVRInput.GetControllerPositionTracked(OVRInput.Controller.LTouch))
        {
            touchControllerLeft.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
            touchControllerLeft.localRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.LTouch);
        }
            

        if (OVRInput.GetControllerPositionTracked(OVRInput.Controller.RTouch))
        {
            touchControllerRight.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
            touchControllerRight.localRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch);
        }

        if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.LTouch))
        {
            Debug.Log("1");
        }

        if (OVRInput.GetDown(OVRInput.Button.Two, OVRInput.Controller.LTouch))
        {
            Debug.Log("2");
        }

        if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTouch))
        {
            Debug.Log("3");
        }

        if (OVRInput.GetDown(OVRInput.Button.Two, OVRInput.Controller.RTouch))
        {
            Debug.Log("4");
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {
            Debug.Log("PrimaryIndexTrigger");
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            Debug.Log("SecondaryIndexTrigger");
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch))
        {
            Debug.Log("PrimaryHandTrigger");
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch))
        {
            Debug.Log("SecondaryHandTrigger");
        }

        if (OVRInput.GetDown(OVRInput.Button.Start))
        {
            Debug.Log("Start");
        }
    }
}
