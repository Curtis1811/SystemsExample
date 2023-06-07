using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballAbilityHandler : AbilityHandler
{
    public FireballAbilityHandler(GameObject ObjectThatSpawned): base(ObjectThatSpawned){

    }


    // This is to spawn our fireball 
    public override void RunAbility()
    {   
        // TODO Offset the obhject by the width of the Object Being spawned
        GameObject temp = new GameObject("Fireball");
        temp.transform.position = ObjectThatSpawned.transform.GetChild(0).position;
        temp.AddComponent<FireBall>().SetObjectThatSpawned(ObjectThatSpawned);

    }
}
