using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitLevel2 : MonoBehaviour
{
    [SerializeField] private GameObject Level2UI;

    private void Awake()
    {
        Level2UI.SetActive(true);
    }
}
