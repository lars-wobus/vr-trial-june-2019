using UnityEngine;

public class PlayerLoosing : MonoBehaviour
{
    [SerializeField]
    private SceneLoader sceneLoader;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name == "Player")
        {
            Debug.Log("Player has lost");
            sceneLoader.LoadScene("LoosingScreen");
        }
    }
}
