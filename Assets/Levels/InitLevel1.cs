using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitLevel1 : MonoBehaviour
{
    [SerializeField] private GameObject Level1UI;

    private void Awake()
    {
        Level1UI.SetActive(true);
    }
}
