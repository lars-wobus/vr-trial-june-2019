using UnityEngine;

public class EnemyCounter : MonoBehaviour
{
    [SerializeField]
    private EnemyController[] controllers;

    [SerializeField]
    private SceneLoader sceneLoader;

    private int remaining = 0;

    private void Start()
    {
        foreach (var c in controllers)
        {
            c.GetEnemyCounter = this;
        }
        remaining = controllers.Length;
    }

    public void ReduceCountByOne()
    {
        remaining--;
        if (remaining <= 0)
        {
            Debug.Log("Player has won");
            sceneLoader.LoadScene("WinningScreen");
        }
    }
}
