using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// If I have enought time I would like to put this on a different thread
// Maybe using unity DOTS systems.

namespace WaveSystem
{
    
    public class WaveManager
    {
        bool WaveComplete = true;
        public int waveCount = 0;
        public float timeBetweenWaves;
        int entityLimit;

        EnemySpawnManager enemySpawnManager;
        List<GameObject> Enemies = new List<GameObject>();

        // This is a list of spawned enemis we can use to recycle
        List<GameObject> PooledEnemies = new List<GameObject>();


        public WaveManager(GameObject[] enemySpawnPoints, float timeBetweenWaves = 5, int entityLimit = 50)
        {
            // Setup for our wavemanager
            this.entityLimit = entityLimit;
            this.timeBetweenWaves = timeBetweenWaves;

            List<Vector3> spawnPoints = new List<Vector3>();
           
            foreach(GameObject go in enemySpawnPoints){
                spawnPoints.Add(go.transform.position);
            }

            enemySpawnManager = new EnemySpawnManager(spawnPoints);
            enemySpawnManager.onSpawnEnemy += AddEnemyToList;
            WaveManagerEvent.onEnemyDie += RemoveEnemyFromList;
        }



        // This is essentially the Update Funciton for the WaveManager
        public void Run(){
            if(WaveComplete){
                onWaveComplete();
            }
           
        }



        // When the wave has been complete we call this to start the next wave
        public void onWaveComplete(){
            waveCount++;
            WaveComplete = false;
            WaveManagerEvent.DisptachOnWaveComplete();
        }



        // This will start the next wave
        public void onWaveStart(){
            WaveManagerEvent.DisptachBatchSpawnEnemies();
        }

   
        public int GetWaveCount(){
            return waveCount;
        }


        void AddEnemyToList(GameObject enemy){
            Enemies.Add(enemy);
        }

        void RemoveEnemyFromList(EnemyEntity enemy,int points){
            // tracks enemys
            Enemies.Remove(enemy.gameObject);
            WaveManagerEvent.DisptachOnAddPoints(points);
            
            if(Enemies.Count <= 0){
                WaveComplete = true;
            }
        }





        // __________________ Corutines _________________________
        public IEnumerator BatchSpawner(){
            //Spawns enemies in batches
            for(int i = 0; i < waveCount * 3; i++){
                yield return new WaitUntil(() => Enemies.Count < entityLimit);
                enemySpawnManager.SpawnEnemy();
                yield return new WaitForSeconds(Random.Range(0.5f,1));
            }
        }

        public IEnumerator WaveTimer(){
            // Wave timer to wait for next wave
            Debug.Log("Waiting for next wave");
            yield return new WaitForSeconds(timeBetweenWaves);
            onWaveStart();
        }


    }
}