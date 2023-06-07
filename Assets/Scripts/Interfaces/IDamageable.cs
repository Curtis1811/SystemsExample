using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable 
{
    void TakeDamage(IDealDamage damager);
    public void Die(bool isDead);
    
    public float GetHealth();
    public void SetHealth(float health);

    
    
}
