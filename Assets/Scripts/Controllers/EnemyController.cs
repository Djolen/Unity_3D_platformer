using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadious = 15f;


    Transform target;
    NavMeshAgent agent;
    public GameObject protivnik;

    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();    
    }

     void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position );
        if (distance <= lookRadious) {
            agent.SetDestination(target.position);
            Animator anim = protivnik.GetComponent<Animator>();
            anim.SetBool("isChasing", true);

            if (distance <= agent.stoppingDistance) {

                FaceTarget();
             
            }
        }

    }


    void FaceTarget() {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation,lookRotation,Time.deltaTime * 5f);
    
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadious);
    }




    public GameManager gm;

    public GameObject igrac;

    public AudioClip hitSound;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {


            if (collision.collider.GetType() == typeof(CapsuleCollider)){

            Animator anim = igrac.GetComponent<Animator>();
            anim.SetTrigger("isHit");

            Animator animator = protivnik.GetComponent<Animator>();
            animator.SetTrigger("Udara");

                AudioSource ac = GetComponent<AudioSource>();
            ac.PlayOneShot(hitSound);

                gm.oduzmiZivot();
            Debug.Log("Pogodjen");
            
            }

            



        }
    }



}
