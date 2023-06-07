using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// A static class for taking damage
public static class TakeDamageBehavior
{

    // Damage an IDamageable with an IDealDamage
    public static void Damage(IDamageable damaged, IDealDamage damager){
        float health = damaged.GetHealth();
        damaged.SetHealth(health -= damager.GetDamage());
        
        if(damaged.GetHealth() <= 0){
            damaged.SetHealth(0);
            Die(damaged);
        }
    }

    // Damage an IDamageable with a float
    public static void Die(IDamageable damaged){
       damaged.Die(true);
       Debug.Log(damaged.GetType() + " is dead");
    }

    

}
