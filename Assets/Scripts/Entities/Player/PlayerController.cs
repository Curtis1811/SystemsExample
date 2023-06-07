using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Main Controller for our player.
public class PlayerController : Mortal
{
    [SerializeField]
    PlayerData playerData;
    
    // List<IAbility> abilities = new List<IAbility>(4);
  
    
    SpriteRenderer spriteRenderer;
    public Rigidbody2D rb2d;
    //Debug
    public float health;


    // Delegates that will communiacte with our Gamemanager.
    #region Delegates

    public delegate void OnPlayerHealthChange(float health);
    public OnPlayerHealthChange onPlayerHealthChange;

    public delegate void OnPlayerReady();
    public OnPlayerReady onPlayerReady;

    public delegate void OnPlayerDead();
    public OnPlayerDead onPlayerDead;


    public delegate void OnPlayerScore(int score);
    public OnPlayerScore onPlayerScore;



    #endregion



    void Start()
    {
        // Setup of our class
        Debug.Log("Start");
        rb2d = this.gameObject.GetComponent<Rigidbody2D>();
        playerData = new PlayerData();
    
        SetupPlayerFromConfig();

        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = playerData.sprite;
        
        health = data.health;

        onPlayerReady?.Invoke();
        playerData.abilities = new List<AbilityHandler>(4);

        // Will add abilites via congif.
        playerData.abilities.Add(new FireballAbilityHandler(this.gameObject));


    }



    void Update()
    {
        // TO-DO Change this out for the Unity Input system using delegates To move our character.
        Move();
        FaceMouse();
        if(data.health <= 0){
            Die();
        }
        
    }


    // Debug Movement until I port Statemachine over from previous project.
    public void Move()
    {

        //TO-DO Change this out for the Unity Input system using delegates To move our character.
        if(Input.GetKey(KeyCode.W))
        {
           this.transform.position += Vector3.up * playerData.speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.S))
        {
            this.transform.position += Vector3.down * playerData.speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.A))
        {
            this.transform.position +=  Vector3.left * playerData.speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.D))
        {
            this.transform.position += Vector3.right * playerData.speed * Time.deltaTime;
        }
        else
        {
            rb2d.velocity = Vector2.zero;
        }

        // only one ability currently
        if(Input.GetMouseButtonDown(0)){
            playerData.abilities[0].RunAbility();
        }

    }


    public void Die()
    {
        Debug.Log("Player Died" + playerData.score);
        this.gameObject.SetActive(false);

    }
 

    // Faces player mouse
    void FaceMouse(){
        Vector2 mousePos = Input.mousePosition;
        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
        Vector2 dir = new Vector2(mousePos.x - objectPos.x, mousePos.y - objectPos.y);
        
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle-90));
        // Mathf.LerpAngle(transform.rotation ,Quaternion.Euler(new Vector3(0, 0, angle-90)),Time.deltaTime * 5f);
    }


    //normaly wouldnt do it this way but running out of time Would make an input hanbdler to interact with what we need.
    public Vector2 GetMouseDirection(){
        Vector2 mousePos = Input.mousePosition;
        return mousePos;
    }

    // player setup from config file
    void SetupPlayerFromConfig(){
        //TO-DO
        PlayerData LoadedData = Resources.Load<PlayerData>("Data/Player/Player");
        playerData.health = LoadedData.health;
        playerData.speed = LoadedData.speed;
        playerData.maxHealth = LoadedData.maxHealth;
        playerData.sprite = LoadedData.sprite;
        playerData.abilities = LoadedData.abilities;
        playerData.mana = LoadedData.mana;
        playerData.maxMana = LoadedData.maxMana;
        playerData.score = LoadedData.score;
        data = playerData;
        
    }



    public void AddPoints(int points){
        playerData.score += points;
        onPlayerScore?.Invoke(playerData.score);
    }



    public override float GetDamage(){
        return 1;
    }



}
