using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Zombie Enemy
public class Zombie : EnemyEntity
{
    [SerializeField]
    // This class will be broken up into a state machine later. We want to have some target selection logic and other logic.
    // We also want to beable to add different states to allow enemies to cast spells eventally and drop them when player kills.

    public GameObject targetToSeek;
    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    //Our data for our enemies
    EnemyData newData;

    public void Start()
    {
        // Setting up out enemy class
        newData = new EnemyData();
        hardData = Resources.Load<EnemyData>("Data/Enemy/Zombie");
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        SetUpObjectFromConfig();
       
    }   


    // this will be removed in place of state machines at a later date.
    public void Update()
    {
        Move();

        if (data.health <= 0)
        {
           Die();
        }
    }



    //TODO Turn this into a state machine.
    public void Attack()
    {
       
    }


    // Basic Move function for our enemy
    public void Move()
    {
        targetToSeek = GameObject.FindGameObjectWithTag("Player");
        if(targetToSeek == null){
            return;
        }
        Vector2 Dir = targetToSeek.transform.position - transform.position;
        Dir.Normalize();
        transform.position = Vector2.MoveTowards(transform.position, targetToSeek.transform.position, data.speed * Time.deltaTime);
        
    }


    // basic collision detection for our enemy
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.GetComponent<Mortal>()){
            other.gameObject.GetComponent<Mortal>().TakeDamage(this);
        }
    }


    // setting up our Enemy data from our Zombie Config file. THe reference is held in Harddata. Will break this out into seperate files to handle the retreavle and loading of data.
    // Put it into an enemy namespace so anything that implement it is insode of enemy namespace. Can use it.
    void SetUpObjectFromConfig(){

        
        //data = new EnemyData();
        newData.ID = hardData.ID;
        newData.enemyName = hardData.enemyName;
        newData.health = hardData.health;
        newData.speed = hardData.speed;
        newData.maxHealth = hardData.maxHealth;
        newData.sprite = hardData.sprite;
        newData.enemyBehavior = hardData.enemyBehavior;
        newData.points = hardData.points;
        this.gameObject.name = newData.enemyName;
        spriteRenderer.sprite = newData.sprite;

        data = newData;
        //newData.enemyType = hardData.enemyType;

        
    }

    public override float GetDamage(){
        return newData.damage;
    }
    
}
