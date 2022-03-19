using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyControl : MonoBehaviour
{
    public bool playerCollision = false;
    public Transform player;
    private NavMeshAgent agent;
    public Animator anim;

    void Start()
    {
        player = GameManager.Instance.chracterControl.transform;
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();

    }

    public void Update()
    {
        if (playerCollision == true)
        {
            agent.SetDestination(player.position);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            anim.SetBool("attack", true);

            playerCollision = true;
        }



    }
    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            anim.SetBool("attack", false);


        }



    }
}
