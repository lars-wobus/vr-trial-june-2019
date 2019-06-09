using UnityEngine;

[SerializeField]
public class RaycastSelector : MonoBehaviour, IRayCastController
{
    [SerializeField]
    private float maxDistance = 100.0f;

    [SerializeField]
    private LayerMask layerMask;

    private RaycastHit hit;

    public void EmitRaycast(Vector3 origin, Vector3 direction)
    {
        if (Physics.Raycast(origin, direction, out hit, maxDistance, layerMask))
        {
            Debug.Log(hit);
        }
    }
}
