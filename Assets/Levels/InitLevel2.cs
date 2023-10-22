using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InitLevel2 : MonoBehaviour
{
    [SerializeField] private GameObject Level2UI;

    private void Awake()
    {
        Level2UI.SetActive(true);
        var root = Level2UI.GetComponent<UIDocument>().rootVisualElement;
        var label = root.Q<UnityEngine.UIElements.Label>("labelInGameLevelName");
        label.text = "Level 2";
        var buttonFail = root.Q<UnityEngine.UIElements.Button>("buttonInGameFail");
        buttonFail.SetEnabled(false);
        buttonFail.visible = false;
    }
}
