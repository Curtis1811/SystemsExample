using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Basic Moral data. 
public abstract class MortalData : ScriptableObject
{

    //This is data for our base Mortal Class.
    // Mortal is defined as anything that can move and die.

    public float health = 100;
    public float maxHealth = 100;
    public float speed = 5;
}
