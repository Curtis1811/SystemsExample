using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obilisk : MonoBehaviour 
{
   
    // didnt get our to implementing but this is the obilisk class and it would have been the thing you must defend
    ObiliskData obilisikData;


    private void Start() {
        obilisikData = new ObiliskData();
    }



    public void Die()
    {
        throw new System.NotImplementedException();
    }



    public void TakeDamage(float damage)
    {
        obilisikData.health -= damage;
    }

  




}
