using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ui1Script : MonoBehaviour
{
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        var button = root.Q<UnityEngine.UIElements.Button>("buttonTitleStart");
        button.clickable.clickedWithEventInfo += B_clicked;
    }

    private void B_clicked(EventBase e)
    {
        Button button = (Button)e.target;
        print("Got: " + button.text);

    }

    void Update()
    {

    }
}
