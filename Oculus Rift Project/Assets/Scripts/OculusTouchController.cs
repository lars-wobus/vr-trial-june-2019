using UnityEngine;

public class OculusTouchController : MonoBehaviour
{
    private const OVRInput.Controller LTouch = OVRInput.Controller.LTouch;
    private const OVRInput.Controller RTouch = OVRInput.Controller.RTouch;

    [SerializeField]
    private Transform touchControllerLeft;

    [SerializeField]
    private Transform touchControllerRight;

    private IParticleEmitter emitterLeft;
    private IParticleEmitter emitterRight;

    private IRayCastController raycastController;

    private void Start()
    {
        raycastController = GetComponent<IRayCastController>();
        emitterLeft = touchControllerLeft.GetComponentInChildren<IParticleEmitter>();
        emitterRight = touchControllerRight.GetComponentInChildren<IParticleEmitter>();
    }

    private void Update()
    {
        if (OVRInput.GetControllerPositionTracked(LTouch))
        {
            touchControllerLeft.localPosition = OVRInput.GetLocalControllerPosition(LTouch);
            touchControllerLeft.localRotation = OVRInput.GetLocalControllerRotation(LTouch);
        }
            

        if (OVRInput.GetControllerPositionTracked(RTouch))
        {
            touchControllerRight.localPosition = OVRInput.GetLocalControllerPosition(RTouch);
            touchControllerRight.localRotation = OVRInput.GetLocalControllerRotation(RTouch);
        }

        if (OVRInput.GetDown(OVRInput.Button.One, LTouch))
        {
            Debug.Log("1");
        }

        if (OVRInput.GetDown(OVRInput.Button.Two, LTouch))
        {
            Debug.Log("2");
        }

        if (OVRInput.GetDown(OVRInput.Button.One, RTouch))
        {
            Debug.Log("3");
        }

        if (OVRInput.GetDown(OVRInput.Button.Two, RTouch))
        {
            Debug.Log("4");
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, LTouch))
        {
            Debug.Log("PrimaryIndexTrigger");
            //raycastController.EmitRaycast(touchControllerLeft.position, touchControllerLeft.forward);
            emitterLeft.StartShooting();
        }

        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, LTouch))
        {
            Debug.Log("PrimaryIndexTrigger");
            //raycastController.EmitRaycast(touchControllerLeft.position, touchControllerLeft.forward);
            emitterLeft.StopShooting();
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, RTouch))
        {
            Debug.Log("SecondaryIndexTrigger");
            //raycastController.EmitRaycast(touchControllerRight.position, touchControllerRight.forward);
            emitterRight.StartShooting();
        }

        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, RTouch))
        {
            Debug.Log("SecondaryIndexTrigger");
            //raycastController.EmitRaycast(touchControllerRight.position, touchControllerRight.forward);
            emitterRight.StopShooting();
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, LTouch))
        {
            Debug.Log("PrimaryHandTrigger");
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, RTouch))
        {
            Debug.Log("SecondaryHandTrigger");
        }

        if (OVRInput.GetDown(OVRInput.Button.Start))
        {
            Debug.Log("Start");
        }
    }
}
