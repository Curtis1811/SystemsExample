using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Player Data
[CreateAssetMenu(fileName = "PlayerData", menuName = "Entity/PlayerData", order = 1)]
public class PlayerData : MortalData
{

    public float damage;
    public float mana;
    public float maxMana;
    // 
    public List<AbilityHandler> abilities;
    public Sprite sprite;

    public int score;
    

    //We can use this to set out variables to keep things hidden but this is just a data file so maybe unnecessary

    // public float Health { get => health; set => health = value; }
    // public float MaxHealth { get => maxHealth; set => maxHealth = value; }
    // public float Speed { get => speed; set => speed = value; }
    // public float Damage { get => damage; set => damage = value; }
    // public float Mana { get => mana; set => mana = value; }
    // public float MaxMana { get => maxMana; set => maxMana = value; }
    // public Ability[] Abilities { get => abilities; set => abilities = value; }




}
