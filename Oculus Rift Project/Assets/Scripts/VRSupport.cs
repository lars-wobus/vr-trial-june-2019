using UnityEngine;

public class VRSupport : MonoBehaviour
{
    [SerializeField]
    private bool enableVR = true;

    private void Awake()
    {
        UnityEngine.XR.XRSettings.enabled = enableVR;
    }
}
