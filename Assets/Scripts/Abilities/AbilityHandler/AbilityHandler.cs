using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbilityHandler
{
    // This class is to handle the abilities of the player
    // When we want to use them we will Call FireballHandler and This will deal woth spawning of the fireball Object
    protected GameObject ObjectThatSpawned;
    public Ability ability;

    // This holds a reference to who spawned it. Would be better to refacor this code so we are using PlayerID and or entity IDs instead of gameobjects
    public AbilityHandler(GameObject ObjectThatSpawned){
        this.ObjectThatSpawned = ObjectThatSpawned;
    }

    // This is so we can just run whatever ability regardless of the type.
    public abstract void RunAbility();
    

}
