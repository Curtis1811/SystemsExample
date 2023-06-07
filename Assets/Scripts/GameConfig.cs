using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This is the game Config file. We will use this to Controll the game settings.

[CreateAssetMenu(fileName = "GameConfig", menuName = "Config/GameConfig", order = 1)]
public class GameConfig : ScriptableObject
{
    // Would be used for more stuff but currently only used for Time between waves
    public float TimeBetweenWaves;

}
