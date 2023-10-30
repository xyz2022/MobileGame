using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InitLevel1 : MonoBehaviour
{
    [SerializeField] private GameObject Level1UI;

    private void Awake()
    {
        Level1UI.SetActive(true);
        /*var root = Level1UI.GetComponent<UIDocument>().rootVisualElement;
        var buttonFail = root.Q<UnityEngine.UIElements.Button>("ButtonFail");
        buttonFail.SetEnabled(false);
        buttonFail.visible = false;*/
    }
}
