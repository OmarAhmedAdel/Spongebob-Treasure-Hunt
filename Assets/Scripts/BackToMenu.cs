using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    UIDocument document;
    Button mainMenu;

    private void OnEnable()
    {
        document = GetComponent<UIDocument>();

        mainMenu = document.rootVisualElement.Q("mainMenu") as Button;
        mainMenu.RegisterCallback<ClickEvent>(OnMainMenuClick);
    }

    private void OnDisable()
    {
        mainMenu.UnregisterCallback<ClickEvent>(OnMainMenuClick);
    }

    private void OnMainMenuClick(ClickEvent ev)
    {
        SceneManager.LoadScene(0);
    }
}
