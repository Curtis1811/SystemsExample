using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WaveSystem;
using ShopSystem;
using GameManagerSystem;

public class GameManager : MonoBehaviour
{

    // Thhis is the game manager that handles everything in the game

    // This will handle game settings
    GameConfig config;
    GameObject player;
    // This is the wave manager that will handle spawning waves
    WaveManager waveManager;
    // This is the shopmanager that will handle player purchasing items from the Shop
    ShopManager shopManager;
    // This is the general UI manager that will hanbdle when to spawn / Enable UI Elements. 
    UIManager uiManager;
    

    // Ingame timer
    public float Timer;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectsWithTag("EnemySpawner");
        SpawnPlayer();
        waveManager = new WaveManager(GameObject.FindGameObjectsWithTag("EnemySpawner"));
        uiManager = new UIManager(this);
        shopManager = new ShopManager();
        config = new GameConfig();


        #region WaveManager Delegates
            WaveManagerEvent.onbatchSpawnEnemies += StartWaveCoroutine;
            WaveManagerEvent.onWaveComplete += WaitForNextWaveCoroutine;
            WaveManagerEvent.onAddPoints += AddPointsToPlayer;
        #endregion

        player.GetComponent<PlayerController>().onTakenDamage += GameManagerEvents.DispatchOnPlayerHealthChange;
        player.GetComponent<PlayerController>().onPlayerReady += PlayerReady;
        //WaveManagerEvent.DisptachBatchSpawnEnemies();
        //WaitForNextWaveCoroutine();
        
        //Highscore highscore = new Highscore();
        //StartCoroutine(highscore.HighscoreEntry());

        

    }

    // Update is called once per frame
    void Update()
    { 
        Timer += Time.deltaTime;
        waveManager.Run();
        uiManager.Run();
       
    }



    void SpawnPlayer(){
        //Spawnes the player ready for play
        player = Instantiate(Resources.Load("Prefabs/Player/Player")) as GameObject;
        player.transform.position = new Vector3(0,0,0);
        player.SetActive(true);
        
    }




    //_________________WaveManager__________________________

    public void StartWaveCoroutine(){
        
        StartCoroutine(waveManager.BatchSpawner());        
    }
    


    public void WaitForNextWaveCoroutine(){
        StartCoroutine(waveManager.WaveTimer());
        GameManagerEvents.DispatchOnWaveStart(waveManager.waveCount);
    }



    //_________________ShopManager__________________________

    public void ShopTimer(){
        //WaveManagerEvent.DisptachOnWaveStart();
    }



    public float GetPlayerHealth(){
        return player.GetComponent<PlayerController>().GetHealth();
    }



    public float GetPlayerMaxHealth(){
        
        return player.GetComponent<PlayerController>().GetPlayerMaxHealth();
    }



    public void PlayerReady(){
        uiManager.ConstructPlayerUI();
    }

    void AddPointsToPlayer(int points){
        player.GetComponent<PlayerController>().AddPoints(points);
    }

}
