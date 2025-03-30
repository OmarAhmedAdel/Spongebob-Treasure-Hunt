using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CreditsController : MonoBehaviour
{
    UIDocument document;

    Button close;

    private void OnEnable()
    {
        document = GetComponent<UIDocument>();

        close = document.rootVisualElement.Q("close") as Button;
        close.RegisterCallback<ClickEvent>(OnCloseClick);
    }

    private void OnDisable()
    {
        close.UnregisterCallback<ClickEvent>(OnCloseClick);
    }

    private void OnCloseClick(ClickEvent ev)
    {
        gameObject.SetActive(false);
    }

}

