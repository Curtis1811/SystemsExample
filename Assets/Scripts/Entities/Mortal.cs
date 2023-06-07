using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Mortal class 

public abstract class Mortal : MonoBehaviour, IDamageable , IDealDamage
{

    protected MortalData data;

    public delegate void OnTakenDamage(float health);
    public OnTakenDamage onTakenDamage;
    

    public virtual void DealDamage( IDamageable damaged)
    {
        //Every mortal can deal damage to another mortal
        TakeDamageBehavior.Damage(damaged, this);
    }

    public virtual void TakeDamage(IDealDamage damager)
    {
        //Every mortal can take damage from another mortal
        TakeDamageBehavior.Damage(this, damager);
        onTakenDamage?.Invoke(data.health);
    }


    public virtual void Die(bool isDead)
    {
        //Every mortal can die
        this.gameObject.SetActive(isDead);
    }

    
    //Getters and Setters
    public abstract float GetDamage();

    public virtual float GetHealth()
    {
        return data.health;
    }

    public virtual float GetPlayerMaxHealth(){
        Debug.Log("Health: " + data.maxHealth);
        return data.maxHealth;
    }

    public virtual void SetHealth(float health)
    {
        data.health = health;
    }

}
