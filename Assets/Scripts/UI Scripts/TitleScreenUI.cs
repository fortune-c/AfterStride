using System;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class TitleScreenUI : MonoBehaviour
{
    private Button startButton;
    private Button quitButton;

    void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        
        startButton = root.Q<Button>("startButton");
        quitButton = root.Q<Button>("quitButton");

        startButton.clicked += OnPlayClicked;
        quitButton.clicked += OnQuitClicked;
    }

    void OnPlayClicked()
    {
        SceneManager.LoadScene("MenuScreen");
    }
    
    void OnQuitClicked()
    {
        Application.Quit();

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
