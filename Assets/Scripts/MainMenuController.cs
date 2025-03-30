using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    UIDocument document;

    Button credits;
    Button play;
    Button quit;

    public GameObject creditsMenu;

    private void OnEnable()
    {
        creditsMenu.SetActive(false);

        document = GetComponent<UIDocument>();

        credits = document.rootVisualElement.Q("credits") as Button;
        credits.RegisterCallback<ClickEvent>(OnCreditsClick);

        play = document.rootVisualElement.Q("play") as Button;
        play.RegisterCallback<ClickEvent>(OnPlayClick);

        quit = document.rootVisualElement.Q("quit") as Button;
        quit.RegisterCallback<ClickEvent>(OnQuitClick);

    }

    private void OnDisable()
    {
        credits.UnregisterCallback<ClickEvent>(OnCreditsClick);
        play.UnregisterCallback<ClickEvent>(OnPlayClick);
        quit.UnregisterCallback<ClickEvent>(OnQuitClick);
    }

    private void OnCreditsClick(ClickEvent ev)
    {
        creditsMenu.SetActive(true);
    }

    private void OnPlayClick(ClickEvent ev)
    {
        SceneManager.LoadScene(1);
    }

    private void OnQuitClick(ClickEvent ev)
    {
        Application.Quit();
    }

}
