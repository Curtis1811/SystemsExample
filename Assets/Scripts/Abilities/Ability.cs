using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This is our base class for all abilities that impolement our different interfaces
public abstract class Ability : MonoBehaviour, IDealDamage, IAbility, ICooldown
{
    // This is the base class for all abilities
    public AnimationClip animation;

    protected AbilityData data;

    public abstract void Fire();



    // }
    // _____________________________________________________________________________________________
    // TODO Break this out into a Damageable Ability Class.
    public void DealDamage(IDamageable damageable)
    {
        // This is to deal damage to a damageable object We do this though a take damage behavior class
        TakeDamageBehavior.Damage(damageable, this);
    }

    // getters and setters for our class
    public float GetDamage()
    {
        return data.damage;
    }

    public float GetCost()
    {
        return data.cost;
    }

    public void GetCooldown()
    {
        throw new System.NotImplementedException();
    }

    public void SetCooldown(float cooldown)
    {
        data.currentCooldown = cooldown;
    }

    int IAbility.GetCost()
    {
        return data.cost;
    }

    float IAbility.GetCooldown()
    {
        return data.cooldown;
    }

    float ICooldown.GetCooldown()
    {
        throw new System.NotImplementedException();
    }

    // Deal damage though collision
    private void OnCollisionEnter(Collision other) {
        DealDamage(other.gameObject.GetComponent<IDamageable>());
    }

    public void StartCooldown()
    {
        throw new System.NotImplementedException();
    }

    public void StopCooldown()
    {
        throw new System.NotImplementedException();
    }

    public bool IsOnCooldown()
    {
        throw new System.NotImplementedException();
    }

    public void UpdateCooldown()
    {
        throw new System.NotImplementedException();
    }

    public void ResetCooldown()
    {
        throw new System.NotImplementedException();
    }


    // _____________________________________________________________________________________________


}
