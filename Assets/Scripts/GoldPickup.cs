using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPickup : MonoBehaviour 
{

    public int value;

    public GameObject pickupEffect;


    private void OnTriggerEnter(Collider other){
        if (other.tag == "Player"){
            FindObjectOfType<GameManager>().AddGold(value);

            Debug.Log("goldpokupljen");

            Instantiate(pickupEffect, transform.position, transform.rotation);

            Destroy(gameObject);
        }

    }
}
