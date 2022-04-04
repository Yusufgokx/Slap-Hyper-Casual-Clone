using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyControl : MonoBehaviour
{
    public bool playerCollision;
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
    
    private void Update()
    {
        if (playerCollision)
        {
            if (playerCollision == true && Vector3.Distance(this.gameObject.transform.position, player.position) > 2.5)
            {
                if (this.gameObject.GetComponent<NavMeshAgent>().enabled == true)
                {
                    agent.SetDestination(player.position);
                    anim.CrossFade("enemyRun", 0.1f);
                }
            }
         //transform.LookAt(player.transform);
        }
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player") && playerCollision == false)
        {
            StartCoroutine(nameof(PlayerTrigger));
            GameManager.Instance.TargetText();
        }
    }

   
    public void DestrucFirst()
    {
        this.gameObject.GetComponent<NavMeshAgent>().enabled = false;
        enemyrb.velocity = Vector3.left * 15;
        enemyrb.isKinematic = false;
        enemyrb.useGravity = true;
        Destroy(this.gameObject, 5);
   
    }
   



   public IEnumerator PlayerTrigger()
    {
        anim.CrossFade("SlapDamage", 0.1f);
        yield return new WaitForSeconds(2.3f);
        playerCollision = true;
    }

}


