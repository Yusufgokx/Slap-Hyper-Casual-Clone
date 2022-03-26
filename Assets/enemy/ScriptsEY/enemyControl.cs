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
    public Rigidbody enemyrb;
    public float destrucStrengthMultiplier = 3f;
    
    
    void Start()
    {
        enemyrb = GetComponent<Rigidbody>();
        playerCollision = false;
        player = GameManager.Instance.chracterControl.transform;
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        

        
        

    }

    public void Update()
    {
        if (playerCollision == true && Vector3.Distance(this.gameObject.transform.position, player.position) > 2)
        {
            agent.SetDestination(player.position);
            anim.SetBool("enemyRun", true);
        }
        else
        {
            anim.SetBool("enemyRun", false);
        }
       
        //  Debug.Log(Vector3.Distance(this.gameObject.transform.position, player.position));
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && playerCollision == false)
        {

            anim.SetBool("attack", true);

            playerCollision = true;

        }
        if (collision.gameObject.CompareTag("Player"))
        {

            anim.SetBool("enemyRun", true);

            playerCollision = true;

        }


    }
    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            anim.SetBool("attack", false);
        

        }
        if (collision.gameObject.CompareTag("Player"))
        {

            anim.SetBool("enemyRun", true);

            playerCollision = true;

        }


    }
    public void DestrucFirst()
    {
        agent.velocity = Vector3.left * 15;
        enemyrb.isKinematic = false;
        enemyrb.useGravity = true;
        
    }


}
