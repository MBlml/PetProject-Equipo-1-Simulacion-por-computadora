using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIControlerMainMenuScene : MonoBehaviour
{

    public Button ButtonPlay;
    public Button ButtonSettings;
    public Button ButtonAbout;
    public Button ButtonClose;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        ButtonPlay = root.Q<Button>("ButtonPlay");
        ButtonSettings = root.Q<Button>("ButtonSettings");
        ButtonAbout = root.Q<Button>("ButtonAbout");
        ButtonClose = root.Q<Button>("ButtonClose");

        ButtonPlay.clicked += ButtonPlayPressed;
        ButtonSettings.clicked += ButtonSettingsPressed;
        ButtonAbout.clicked += ButtonAboutPressed;
        ButtonClose.clicked += ButtonClosePressed;
        
    }

    void ButtonPlayPressed()
    {
        SceneManager.LoadScene("Main");
    }
    void ButtonSettingsPressed()
    {
        SceneManager.LoadScene("SettingsScene");
    }
    void ButtonAboutPressed()
    {
        SceneManager.LoadScene("AboutScene");
    }
    void ButtonClosePressed()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
