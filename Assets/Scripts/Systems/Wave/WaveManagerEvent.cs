using System.Collections;
using System.Collections.Generic;
using UnityEngine;




namespace WaveSystem{

    // We are using this as a way for anything that needs access to wave events to hook in and listen

    public static class WaveManagerEvent
    {
        public delegate void OnWaveComplete();
        public static event OnWaveComplete onWaveComplete;
        public static void DisptachOnWaveComplete()
        {
            onWaveComplete?.Invoke();
        }


        public delegate void OnWaveStart();
        public static event OnWaveStart onWaveStart;
        public static void DisptachOnWaveStart()
        {
            onWaveStart?.Invoke();
        }


        public delegate void OnBatchSpawnEnemies();
        public static event OnBatchSpawnEnemies onbatchSpawnEnemies;
        public static void DisptachBatchSpawnEnemies()
        {
            onbatchSpawnEnemies?.Invoke();
        }
        

        
        public delegate void OnEnemyDie(EnemyEntity enemy,int points);
        public static event OnEnemyDie onEnemyDie;
        public static void DisptachOnEnemyDie(EnemyEntity enemy, int points)
        {
            onEnemyDie?.Invoke(enemy,points);
        }
        
        // When an enemy dies we will dispatch this event to add points to the player
        public delegate void OnAddPoints(int points);
        public static event OnAddPoints onAddPoints;
        public static void DisptachOnAddPoints(int points)
        {
            onAddPoints?.Invoke(points);
        }

    }

}
