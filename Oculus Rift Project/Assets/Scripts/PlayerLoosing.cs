using UnityEngine;

public class PlayerLoosing : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name == "Player")
        {
            Debug.Log("Player has lost");
        }
    }
}
