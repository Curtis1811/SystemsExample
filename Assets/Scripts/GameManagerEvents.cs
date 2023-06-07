using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GameManagerSystem{

    public static class GameManagerEvents 
    {
        public delegate void OnWaveStart(int waveNumber);
        public static event OnWaveStart onWaveStart;
        public static void DispatchOnWaveStart(int waveNumber){
            onWaveStart?.Invoke(waveNumber);
        }



        public delegate void OnPlayerHealthChange(float health);
        public static event OnPlayerHealthChange onPlayerHealthChange;
        public static void DispatchOnPlayerHealthChange(float health){
            onPlayerHealthChange?.Invoke(health);
        }


    }




}
