using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using GameManagerSystem;


public class UIManager
{
    // This will be responsable for Creating UI Elements. 

    public GameManager gameManager;
    public GameObject playerUI;
    public GameObject ShopUI;

    UIDocument PlayerUIDocument;
    UIDocument GameOverUIDocument;

    PlayerUIBehavior playerUIBehavior;
    Canvas canvas;


    //________________________________________________

    public UIManager(GameManager gameManager){

        this.gameManager = gameManager;
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        ShopUI = GameObject.Find("ShopUI");

        //GameManagerEvents.onWaveStart += SetWaveCount;
        GameManagerEvents.onPlayerHealthChange += playerChangeHealth;
    }


    public void Run() {
        playerUIBehavior.SetTimer(gameManager.Timer);
    }


    
    public void SetWaveCount(int waveCount){
        playerUIBehavior.SetWave(waveCount);

    }



    public void ConstructPlayerUI(){
        playerUIBehavior = canvas.transform.Find("PlayerUI").gameObject.AddComponent<PlayerUIBehavior>();        
        playerUIBehavior.SetMaxHealth(gameManager.GetPlayerMaxHealth());
        playerUIBehavior.SetHealth(gameManager.GetPlayerHealth());
    }
    


    public void playerChangeHealth(float health){
        Debug.Log("DamageTaken");
        playerUIBehavior.SetHealth(health);
    }



    public void ConstructGameOver(){
        GameOverUIDocument = GameObject.Find("GameOverUI").GetComponent<UIDocument>();
        
    }
    
}
