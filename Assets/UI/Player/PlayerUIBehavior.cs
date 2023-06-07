using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using GameManagerSystem;


public class PlayerUIBehavior : MonoBehaviour
{
    UIDocument uiDocument;
    ProgressBar healthBar;
    VisualElement healthbar;
    VisualElement timerVisualElement;
    VisualElement waveContainer;
    VisualElement WaveCountdownContainter;

    float timer;
    Label timerLabel;
    Label waveLabel;
    Label waveCountLable;

    private void OnEnable(){

        uiDocument = GetComponent<UIDocument>();
      
        timerVisualElement = uiDocument.rootVisualElement.Q<VisualElement>("Timer");
        timerLabel = uiDocument.rootVisualElement.Q<Label>("TimerLabel");
      
        waveContainer = uiDocument.rootVisualElement.Q<VisualElement>("WaveContainer");
        waveLabel = uiDocument.rootVisualElement.Q<Label>("WaveLabel");

        WaveCountdownContainter = uiDocument.rootVisualElement.Q<VisualElement>("WaveCountdownContainer");
        waveCountLable = uiDocument.rootVisualElement.Q<Label>("WaveCountLable");

        healthBar = uiDocument.rootVisualElement.Q<ProgressBar>("HealthBar");
        healthBar.value = 50;
        healthBar.highValue = 100;

        GameManagerSystem.GameManagerEvents.onWaveStart += SetWave;

    }

    public void SetTimer(float timer)
    {
        timerLabel.text = "RunTime: " + timer.ToString("F1");
    }

    
    
    public void SetWave(int currentWave)
    {
        waveCountLable.text = "Wave:" + currentWave.ToString();
    }


    
    public void SetHealth(float health)
    {
        healthBar.value = health;
    }

    

    public void SetMaxHealth(float maxHealth){
        healthBar.highValue = maxHealth;
    }

}
