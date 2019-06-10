using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private int health = 100;

    private GameObject target;
    private Lifebar lifebar;
    private float startHealth;
    private NavMeshAgent agent;

    public EnemyCounter GetEnemyCounter { get; set; }

    private void Start()
    {
        lifebar = GetComponentInChildren<Lifebar>();
        lifebar.SetLife(1);
        startHealth = health;
        target = GameObject.FindWithTag("Player");
        var animator = GetComponentInChildren<Animator>();
        animator.SetBool("Walk", true);

        NavMeshHit closestHit;
        if (NavMesh.SamplePosition(transform.position, out closestHit, 500, 1))
        {
            transform.position = closestHit.position;
            agent = GetComponent<NavMeshAgent>();
        }
    }

    private void Update()
    {
        if (agent.isOnNavMesh)
        {
            agent.destination = target.transform.position;
        }
    }

    private void OnProjectHit()
    {
        health -= 1;
        if (health == 0)
        {
            Destroy(gameObject);
            GetEnemyCounter?.ReduceCountByOne();
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
