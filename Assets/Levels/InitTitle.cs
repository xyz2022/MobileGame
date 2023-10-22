using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitTitle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject titleUI;
    void Awake()
    {
        titleUI.SetActive(true);
    }
}
