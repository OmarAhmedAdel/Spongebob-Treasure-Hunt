using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class SquidwardSceneSwitch : MonoBehaviour
{
    private UIDocument _document;
    private Button _buttonOne;
    private Button _buttonTwo;
    private const float DelayTime = 30f; // Delay time in seconds

    private void Awake()
    {
        _document = GetComponent<UIDocument>();
        _document.rootVisualElement.style.display = DisplayStyle.None; // Hide UI initially

        // Start the coroutine to show the UI after 30 seconds
        StartCoroutine(ShowUIAfterDelay());
    }

    private IEnumerator ShowUIAfterDelay()
    {
        yield return new WaitForSeconds(DelayTime);

        // Show the UI
        _document.rootVisualElement.style.display = DisplayStyle.Flex;

        // Initialize the buttons after showing the UI
        _buttonOne = _document.rootVisualElement.Q<Button>("RoadOneButton");
        _buttonOne.RegisterCallback<ClickEvent>(OnRoadOneButtonClicked);

        _buttonTwo = _document.rootVisualElement.Q<Button>("RoadTwoButton");
        _buttonTwo.RegisterCallback<ClickEvent>(OnRoadTwoButtonClicked);
    }

    private void OnDisable()
    {
        if (_buttonOne != null)
        {
            _buttonOne.UnregisterCallback<ClickEvent>(OnRoadOneButtonClicked);
        }
        if (_buttonTwo != null)
        {
            _buttonTwo.UnregisterCallback<ClickEvent>(OnRoadTwoButtonClicked);
        }
    }

    private void OnRoadOneButtonClicked(ClickEvent evt)
    {
        Debug.Log("Road One Button Clicked");
        SceneManager.LoadSceneAsync(5);
    }

    private void OnRoadTwoButtonClicked(ClickEvent evt)
    {
        Debug.Log("Road Two Button Clicked");
        SceneManager.LoadSceneAsync(6);
    }
}
