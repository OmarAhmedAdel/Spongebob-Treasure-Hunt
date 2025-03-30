using UnityEngine;
using UnityEngine.UIElements;

public class AutoScroller : MonoBehaviour
{
    public float scrollSpeed = 50f;
    public bool horizontalScroll = false;
    private ScrollView scrollView;

    private void OnEnable()
    {
        var document = GetComponent<UIDocument>();
        scrollView = document.rootVisualElement.Q<ScrollView>();

        if (scrollView == null)
        {
            Debug.LogError("No ScrollView found in the UI Document!");
        }
    }

    private void Update()
    {
        if (scrollView == null) return;

        if (horizontalScroll)
        {
            float newValue = scrollView.horizontalScroller.value + scrollSpeed * Time.deltaTime;

            if (newValue > scrollView.horizontalScroller.highValue)
                newValue = 0;

            scrollView.horizontalScroller.value = newValue;
        }
        else
        {
            float newValue = scrollView.verticalScroller.value + scrollSpeed * Time.deltaTime;

            if (newValue > scrollView.verticalScroller.highValue)
                newValue = 0;

            scrollView.verticalScroller.value = newValue;
        }
    }
}
