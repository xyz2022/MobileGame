using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InitLose : MonoBehaviour
{
    [SerializeField] private GameObject LoseUI;

    private void Awake()
    {
        LoseUI.SetActive(true);
        var root = LoseUI.GetComponent<UIDocument>().rootVisualElement;
        var label = root.Q<UnityEngine.UIElements.Label>("labelWinLose");
        label.text = "YOU Lose 999";
    }
}
