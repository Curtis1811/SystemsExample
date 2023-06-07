using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using GameManagerSystem;
using UnityEngine.SceneManagement;

public class MainMenuUIBehavior : MonoBehaviour
{
    UIDocument uiDocument;
    VisualElement play;
    VisualElement exit;
    VisualElement viewHighscore;

    private void OnEnable() {
        uiDocument = GetComponent<UIDocument>();

        play = uiDocument.rootVisualElement.Q<VisualElement>("Play");
        play.AddManipulator(new Clickable(OnPlay));

        exit = uiDocument.rootVisualElement.Q<VisualElement>("Exit");
        exit.AddManipulator(new Clickable(OnExit));

        viewHighscore = uiDocument.rootVisualElement.Q<VisualElement>("ViewHighscore");
        viewHighscore.AddManipulator(new Clickable(OnViewHighscore));


    }

    void OnPlay(){
        SceneManager.LoadScene("Game");
    }

    void OnExit(){
        Application.Quit();
    }

    void OnViewHighscore(){
        // This will be to show the highscore
        
    }

}
