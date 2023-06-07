using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// data class for our AbilityData
[CreateAssetMenu(fileName = "New Ability", menuName = "Ability")]
public class AbilityData : ScriptableObject
{

    public enum AbilityType
    {
        Projectile,
        Melee,
        Buff,
        Debuff,
        Summon
    }

    public AbilityType abilityType;

    //Can maybe break this out into a seperate Damage Ability
    public float damage;
    public float speed;
   
    public float cooldown;
    public float currentCooldown;
    public float range;
    [TextArea(3,10)]
    public string description;
    public string name;

    public Sprite icon;
    public bool isOnCooldown;
   
    public int cost;



    // public float GetCooldown()
    // {
    //     return cooldown;
    // }

    // public bool IsOnCooldown()
    // {
    //     return isOnCooldown;
    // }

    // public void ResetCooldown()
    // {
    //     throw new System.NotImplementedException();
    // }

    // public void SetCooldown(float cooldown)
    // {
    //     this.cooldown = cooldown;
    // }

    // public void StartCooldown()
    // {
    //     throw new System.NotImplementedException();
    // }

    // public void StopCooldown()
    // {
    //     throw new System.NotImplementedException();
    // }

    // public void UpdateCooldown()
    // {
    //     throw new System.NotImplementedException();
    // }

    
}
