using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This will manage the Spawning of enemies. We wil use this to random,ize between types of enemies
public class EnemySpawnManager
{
    // This will manage the Spawning of enemies.
    

    List<Vector3> SpawnPoints = new List<Vector3>();
    GameObject ObjectToSpawn = Resources.Load<GameObject>("Prefabs/Enemys/Enemy");

    public delegate void OnSpawnEnemyDelegate(GameObject Enemy);
    public OnSpawnEnemyDelegate onSpawnEnemy;


    public EnemySpawnManager(List<Vector3> SpawnPoints)
    {
        this.SpawnPoints = SpawnPoints;
    }


    public void SpawnEnemy()
    {
        // EnemmyToSpawn.AddComponent<Zombie>();
        onSpawnEnemy?.Invoke(ConstructEnemy());
    }


    public GameObject ConstructEnemy(){
        GameObject temp = Object.Instantiate<GameObject>(ObjectToSpawn, SpawnPoints[Random.Range(0,SpawnPoints.Count-1)], Quaternion.identity);
        temp.AddComponent<Zombie>();
        return temp;
    }


    public void randomType(){
        Debug.Log("Random Type");

    }

    
}
