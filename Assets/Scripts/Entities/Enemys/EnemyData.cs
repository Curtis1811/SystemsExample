using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  // Data for our enemys that inherit from Mortal

[CreateAssetMenu(fileName = "EnemyData", menuName = "Entity/EnemyData", order = 1)]
public class EnemyData : MortalData
{
  
    enum EnemyType
    {
        Melee,
        Ranged,
        Boss
    }


    //public EnemyType enemyType;
    public string enemyName;
    public float damage;
    public int ID;
    public int points;
    public IEnemyBehavior enemyBehavior;

    public Sprite sprite;


    public EnemyData()//float speed = 10, float health = 100, float maxHealth = 100, float damage = 5,string enemyName = "Enemy")
    {
        // this.speed = speed;
        // this.health = health;
        // this.maxHealth = maxHealth;
        // this.damage = damage;
        // this.enemyName = enemyName;
        
    }
}
