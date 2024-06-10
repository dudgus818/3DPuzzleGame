using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    private Transform player;
    private NavMeshAgent navMeshAgent;
    private float lifeTime = 10;

    public void Initialize(Transform playerTransform, float lifetime)
    {
        player = playerTransform;
        lifeTime = lifetime;
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.SetDestination(player.position);

        Invoke("DestroyEnemy", lifeTime);
    }

    private void Update()
    {
        if (player != null)
        {
            navMeshAgent.SetDestination(player.position);
        }
    }

    private void DestroyEnemy()
    {
        Destroy(gameObject);
    }
}
