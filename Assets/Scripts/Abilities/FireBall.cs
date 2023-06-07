using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FireBall : ProjectileAbility
{
    Rigidbody2D rb;
    FireballBehavior fireballBehavior;
    SpriteRenderer spriteRenderer;
    new Collider2D collider;
    GameObject objectThatSpawned;
    GameObject ProjectileSpawn;
    Vector2 direction;


    public void Start(){
        // Here we want to construct out Gameovject taht we are going to instantiate.
        rb = this.gameObject.AddComponent<Rigidbody2D>();
        collider = this.gameObject.AddComponent<CircleCollider2D>();
        spriteRenderer =this.gameObject.AddComponent<SpriteRenderer>();
        data = Resources.Load<AbilityData>("Data/Ability/Fireball");
        
        spriteRenderer.sprite = data.icon;

        rb.gravityScale = 0;
       
    }


    private void FixedUpdate(){
        // We are moving our object toward a position
        Move(direction);
    }


    public override void Fire(){
        Debug.Log("Fireball Run");
    }

    public void Move(Vector2 direction){
        //Moving our object in a direction
        direction.Normalize();
        this.transform.position += new Vector3(direction.x, direction.y,0) * data.speed * Time.deltaTime;
        //rb.MovePosition(direction * abilityData.speed * Time.deltaTime);
    }

    //Setters for Direciton
    public void SetDireciton(Vector2 direction){
        this.direction = direction;
    }


    //Setters for ObjectThatSpawned Will change to ID
    public void SetObjectThatSpawned(GameObject ObjectThatSpawned){
        this.objectThatSpawned = ObjectThatSpawned;
       
        SetDireciton(objectThatSpawned.transform.up);
    }


    //Collision
    private void OnCollisionEnter2D(Collision2D other) {
        
        if(other.gameObject.GetComponent<Mortal>() && other.gameObject != objectThatSpawned){
            other.gameObject.GetComponent<Mortal>().TakeDamage(this);
            Destroy(this.gameObject);
        }
       
       
        // else if(other.gameObject.tag == "Enemy"){
        //     Debug.Log("Hit Enemy");
        // }
        // else if(other.gameObject.tag == "Wall"){
        //     Debug.Log("Hit Wall");
        // }
        // else{
        //     Debug.Log("Hit Something");
        // }
    

    }
      
}
