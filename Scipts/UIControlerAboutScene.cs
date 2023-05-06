using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class UIControlerAboutScene : MonoBehaviour
{
    public Button ButtonClose;
    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        ButtonClose = root.Q<Button>("ButtonClose");

        ButtonClose.clicked += ButtonClosePressed;
    }
    void ButtonClosePressed()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
