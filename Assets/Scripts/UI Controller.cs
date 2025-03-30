using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UIElements;

public class UIController : MonoBehaviour
{
    public UIDocument uiDocument1;
    public UIDocument uiDocument2;
    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShowDocument1();
            Debug.Log("Doc 1");
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            ShowDocument2();
            Debug.Log("Doc 2");
        }
    }

    public void ShowDocument1()
    {
        uiDocument1.rootVisualElement.style.display = DisplayStyle.Flex;
        uiDocument2.rootVisualElement.style.display = DisplayStyle.None;
    }

    public void ShowDocument2()
    {
        uiDocument1.rootVisualElement.style.display = DisplayStyle.None;
        uiDocument2.rootVisualElement.style.display = DisplayStyle.Flex;
    }
}

