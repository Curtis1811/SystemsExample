using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using GameManagerSystem;
using UnityEngine.SceneManagement;

public class GameOverBehavior : MonoBehaviour
{

    VisualElement PlayAgainBtn;
    VisualElement UploadBtn;


    private void OnEnable() {
        PlayAgainBtn = GetComponent<UIDocument>().rootVisualElement.Q<VisualElement>("PlayAgain");
        PlayAgainBtn.AddManipulator(new Clickable(PlayAgain));

        UploadBtn = GetComponent<UIDocument>().rootVisualElement.Q<VisualElement>("Upload");
        UploadBtn.AddManipulator(new Clickable(Upload));

    }


    void PlayAgain(){
        SceneManager.LoadScene("Game");
        Debug.Log("PlayAgain");
    }

    void Upload(){
        Debug.Log("Upload");
    }

}
