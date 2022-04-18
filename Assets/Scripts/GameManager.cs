using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int currentGold;

    public Text goldText;

    public Text zivotiT;

    public Text mrtav;

    public int zivoti = 10;

    public GameObject nextLVL; 

    public int goldToNext;

    public GameObject eg;




    public void AddGold(int goldToAdd){

        currentGold += goldToAdd;
        goldText.text = "Gold: " + currentGold;
        if (currentGold == goldToNext) {
            if (SceneManager.GetActiveScene().name == "Level1") {
            PlayerPrefs.SetInt("brz", zivoti);
            nextLVL.SetActive(true);
            }else if(SceneManager.GetActiveScene().name == "Level2")
            {
                Cursor.lockState = CursorLockMode.None;
                finished();
            }

        }
    }

    public void AddLife()
    {
        zivoti++;
        zivotiT.text = "Health: " + zivoti;
    }


    public void setZivoti(int noviBR){
        zivoti = noviBR;
    }

    public void oduzmiZivot()
    {
        zivoti--;
        if (zivoti <= 0)
        {
            Cursor.lockState = CursorLockMode.None;
            respawn();
        }else
        zivotiT.text = "Health: " + zivoti;
    }


    public void respawn() {

        //Cursor.lockState = CursorLockMode.None;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        StartCoroutine(RespawnCO());

    }

    public float rLenght;

    public GameObject igrac;
    public IEnumerator RespawnCO(){

        Time.timeScale = 0.1f;
        igrac.GetComponent<Animator>().SetTrigger("isDead");
        zivotiT.text = "Health: 0";
        mrtav.gameObject.SetActive(true);
        yield return new WaitForSeconds(rLenght);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.None;
        if (SceneManager.GetActiveScene().name == "Level2") { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2); }else
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public IEnumerator finishedCO()
    {

        Time.timeScale = 0.1f;
        eg.gameObject.SetActive(true);
        yield return new WaitForSeconds(rLenght);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }


    public void finished(){
        StartCoroutine(finishedCO());
    }




}
