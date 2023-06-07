using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WaveSystem;

public abstract class EnemyEntity: Mortal
{
   
   // this is a reference to any hard data we may use. 
    public EnemyData hardData;
  
   // Return the points for a kill. Will be used as money later on.
    public int GetPoints(){
        
        return hardData.points;
    }
    

    // Run when enemy dies.
    public void Die()
    {
        WaveManagerEvent.DisptachOnEnemyDie(this, GetPoints());
        this.gameObject.SetActive(false);
    }
}
