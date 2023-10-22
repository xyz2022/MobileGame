using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitLevel3 : MonoBehaviour
{
    [SerializeField] private GameObject Level3UI;

    private void Awake()
    {
        Level3UI.SetActive(true);
    }
}
