using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{

    public GameObject sword;

    public bool canAttack = true;

    public float AttackCooldown = 1.0f;

    public bool isAttacking = false;

    public AudioClip attackSound;

    public PauseMenu pm;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (canAttack == true)
            {

                SwordAttack();


            }


        }
    }
    public void SwordAttack()
    {
        isAttacking = true;
        canAttack = false;
        Animator anim = sword.GetComponent<Animator>();
        anim.SetTrigger("Attack");
        //StartCoroutine(delaySound()); 
        if (!PauseMenu.isPaused) { 
        AudioSource ac = GetComponent<AudioSource>();
        ac.PlayOneShot(attackSound);
        }        
        StartCoroutine(ResetAttackCooldown());
    }


    IEnumerator ResetAttackCooldown()
    {
        StartCoroutine(ResetAttackBool());
        yield return new WaitForSeconds(AttackCooldown);
        canAttack = true;
    }

    IEnumerator ResetAttackBool()
    {
        
        yield return new WaitForSeconds(1.0f);
        isAttacking = false;

    }

    IEnumerator delaySound()
    {
        yield return new WaitForSeconds(1);

    }
}
