using UnityEngine;

public class EnemyCounter : MonoBehaviour
{
    [SerializeField]
    private EnemyController[] controllers;

    private int remaining = 0;

    private void Start()
    {
        foreach (var c in controllers)
        {
            c.GetEnemyCounter = this;
        }
    }

    public void ReduceCountByOne()
    {
        remaining--;
        if (remaining <= 0)
        {
            Debug.Log("Player has won");
        }
    }
}
