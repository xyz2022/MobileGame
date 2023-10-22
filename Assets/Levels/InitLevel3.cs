using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InitLevel3 : MonoBehaviour
{
    [SerializeField] private GameObject Level3UI;

    private void Awake()
    {
        Level3UI.SetActive(true);
        var root = Level3UI.GetComponent<UIDocument>().rootVisualElement;
        var label = root.Q<UnityEngine.UIElements.Label>("labelInGameLevelName");
        label.text = "Level 3";
    }
}
