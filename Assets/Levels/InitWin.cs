using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InitWin : MonoBehaviour
{
    [SerializeField] private GameObject WinUI;

    private void Awake()
    {
        WinUI.SetActive(true);
        var root = WinUI.GetComponent<UIDocument>().rootVisualElement;
        var label = root.Q<UnityEngine.UIElements.Label>("labelWinLose");
        label.text = "YOU WIN 1050";
    }
}
