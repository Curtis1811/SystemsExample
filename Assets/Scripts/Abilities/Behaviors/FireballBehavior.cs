using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballBehavior : MonoBehaviour 
{
   // TODO This will be used to execute any of the fireball relavent code.
   Vector2 direction;
   private void Update() {
        
   }

   public void Move(Vector2 direction){
      Debug.Log("Fireball is moving");
   }
}
