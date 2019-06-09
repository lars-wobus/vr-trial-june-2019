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
    }
}
