using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class character_select : MonoBehaviour
{
    private UIDocument _document;

    private Button patrickButton;
    private Button squidwardButton;

    public PlayableDirector timelineDirector; 

    private void OnEnable()
    {
        _document = GetComponent<UIDocument>();

        patrickButton = _document.rootVisualElement.Q("PatrickButton") as Button;
        patrickButton.RegisterCallback<ClickEvent>(OnPatrickButtonClick);

        squidwardButton = _document.rootVisualElement.Q("SquidwardButton") as Button;
        squidwardButton.RegisterCallback<ClickEvent>(OnSquidwardButtonClick);

        timelineDirector.Pause();
    }

    private void OnDisable()
    {
        patrickButton.UnregisterCallback<ClickEvent>(OnPatrickButtonClick);
        squidwardButton.UnregisterCallback<ClickEvent>(OnSquidwardButtonClick);
    }

    private void OnPatrickButtonClick(ClickEvent ev)
    {
        Debug.Log("Clicked on Patrick");
        SceneManager.LoadScene(3);
    }

    private void OnSquidwardButtonClick(ClickEvent ev)
    {
        Debug.Log("Clicked on Squidward");
        SceneManager.LoadScene(2);
    }

}
