using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{

    public WeaponController wc;
    public GameObject protivnik, protivnik2, protivnik3, protivnik4, protivnik5, protivnik6, protivnik7;
    int count = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0, count6 = 0, count7 = 0;
    public bool hittable=true;

    //public float attDelay = 0.5f;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && wc.isAttacking)
        {
            if (hittable) {

            hittable = false;
            Animator anim = protivnik.GetComponent<Animator>();
            anim.SetTrigger("Hit");

            Debug.Log("Neprijatelj");



            count++; 

              

            if (count == 3)

            {
                    delayKill();
                    Destroy(collision.gameObject);
                count = 0;
            }

                StartCoroutine(delay());
            
            }
            


        }

        if (collision.gameObject.CompareTag("Enemy2") && wc.isAttacking)
        {
            if (hittable)
            {

                hittable = false;
                Animator anim = protivnik2.GetComponent<Animator>();
                anim.SetTrigger("Hit");

                Debug.Log("Neprijatelj");



                count2++;



                if (count2 == 3)

                {
                    delayKill();
                    Destroy(collision.gameObject);
                    count2 = 0;
                }

                StartCoroutine(delay());

            }



        }

        if (collision.gameObject.CompareTag("Enemy3") && wc.isAttacking)
        {
            if (hittable)
            {

                hittable = false;
                Animator anim = protivnik3.GetComponent<Animator>();
                anim.SetTrigger("Hit");

                Debug.Log("Neprijatelj");



                count3++;



                if (count3 == 3)

                {
                    delayKill();
                    Destroy(collision.gameObject);
                    count3 = 0;
                }

                StartCoroutine(delay());

            }



        }

        if (collision.gameObject.CompareTag("Enemy4") && wc.isAttacking)
        {
            if (hittable)
            {

                hittable = false;
                Animator anim = protivnik4.GetComponent<Animator>();
                anim.SetTrigger("Hit");

                Debug.Log("Neprijatelj");



                count4++;



                if (count4 == 3)

                {
                    delayKill();
                    Destroy(collision.gameObject);
                    count4 = 0;
                }

                StartCoroutine(delay());

            }



        }

        if (collision.gameObject.CompareTag("Enemy5") && wc.isAttacking)
        {
            if (hittable)
            {

                hittable = false;
                Animator anim = protivnik5.GetComponent<Animator>();
                anim.SetTrigger("Hit");

                Debug.Log("Neprijatelj");



                count5++;



                if (count5 == 3)

                {
                    delayKill();
                    Destroy(collision.gameObject);
                    count5 = 0;
                }

                StartCoroutine(delay());

            }



        }

        if (collision.gameObject.CompareTag("Enemy6") && wc.isAttacking)
        {
            if (hittable)
            {

                hittable = false;
                Animator anim = protivnik6.GetComponent<Animator>();
                anim.SetTrigger("Hit");

                Debug.Log("Neprijatelj");



                count6++;



                if (count6 == 3)

                {
                    delayKill();
                    Destroy(collision.gameObject);
                    count6 = 0;
                }

                StartCoroutine(delay());

            }



        }

        if (collision.gameObject.CompareTag("Enemy7") && wc.isAttacking)
        {
            if (hittable)
            {

                hittable = false;
                Animator anim = protivnik7.GetComponent<Animator>();
                anim.SetTrigger("Hit");

                Debug.Log("Neprijatelj");



                count7++;



                if (count7 == 3)

                {
                    delayKill();
                    Destroy(collision.gameObject);
                    count7 = 0;
                }

                StartCoroutine(delay());

            }



        }

        
    }

    IEnumerator delay(){
        yield return new WaitForSeconds(1f);
        hittable = true;
    }


    void delayKill(){
        StartCoroutine(delayAnim());
    }

    IEnumerator delayAnim()
    {
        yield return new WaitForSeconds(1);

    }









}
