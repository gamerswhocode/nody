using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopoAttack : MonoBehaviour
{
    public float attackRange = 1f;
    public Animator animator;

    private Transform player;
    private bool topoSpawned = false;
    

    private void Start()
    {
        player = GameObject.Find("Jugador").transform;
    }
    public void OnTopoSpawnComplete()
    {
        topoSpawned = true;
    }
    void Update()
    {
        if (!topoSpawned) return;

        // Get distance to player
        Vector3 directionVector = player.position - transform.position;
        float distance = directionVector.magnitude;
        if (distance <= attackRange)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("TopoIdle"))
            {
                animator.Play("TopoAttack");
            }
        }

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(transform.position, attackRange);
    }
}
