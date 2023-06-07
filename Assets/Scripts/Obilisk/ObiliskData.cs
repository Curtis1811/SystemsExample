using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Obilisk data
[CreateAssetMenu(fileName = "ObiliskData", menuName = "Entity/ObiliskData", order = 1)]
public class ObiliskData : ScriptableObject
{
    public float health;
    public float maxHealth;
    public float damage;

    public ObiliskData(float health = 100, float maxHealth= 100, float damage = 5)
    {
        this.health = health;
        this.maxHealth = maxHealth;
        this.damage = damage;
    }


}
