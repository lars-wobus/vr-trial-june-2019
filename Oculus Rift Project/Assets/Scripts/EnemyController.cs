using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private int health = 100;

    private Lifebar lifebar;
    private float startHealth;

    private void Start()
    {
        lifebar = GetComponentInChildren<Lifebar>();
        lifebar.SetLife(1);
        startHealth = health;
    }

    private void OnProjectHit()
    {
        health -= 1;
        if (health == 0)
        {
            Destroy(gameObject);
            return;
        }
        lifebar.SetLife(health / startHealth);
    }

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("OnParticleCollision");
        OnProjectHit();
    }
}
