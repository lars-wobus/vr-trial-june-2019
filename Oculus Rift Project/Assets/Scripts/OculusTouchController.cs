using UnityEngine;

public class OculusTouchController : MonoBehaviour
{
    [SerializeField]
    private Transform touchControllerLeft;

    [SerializeField]
    private Transform touchControllerRight;

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetControllerPositionTracked(OVRInput.Controller.LTouch))
            touchControllerLeft.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);

        if (OVRInput.GetControllerPositionTracked(OVRInput.Controller.RTouch))
            touchControllerRight.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
    }
}
