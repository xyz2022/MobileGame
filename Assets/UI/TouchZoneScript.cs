using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UIElements;

public class TouchZoneScript : MonoBehaviour
{
    [SerializeField] private SceneLoader.SceneNames nextScene;
    SceneLoader loader;

    Button LBut;
    Button RBut;

    Rectangle r1;
    PanelEventHandler eventHandler;
    void Awake()
    {
        loader = FindObjectOfType<SceneLoader>();
        eventHandler = gameObject.GetComponent<PanelEventHandler>();
        var root = GetComponent<UIDocument>().rootVisualElement;

        LBut = root.Q<UnityEngine.UIElements.Button>("LBut");
        RBut = root.Q<UnityEngine.UIElements.Button>("RBut");
        LBut.RegisterCallback<PointerDownEvent>(MouseZoneL, TrickleDown.TrickleDown);
        RBut.RegisterCallback<PointerDownEvent>(MouseZoneR, TrickleDown.TrickleDown);

        var buttonComplete = root.Q<UnityEngine.UIElements.Button>("ButtonSkip");
        buttonComplete.clickable.clickedWithEventInfo += LevelSkip;
        var buttonFail = root.Q<UnityEngine.UIElements.Button>("ButtonFail");
        buttonFail.clickable.clickedWithEventInfo += LevelFail;
    }
    void MouseZoneL(PointerDownEvent evt)
    {
        print("L ");
    }
    void MouseZoneR(PointerDownEvent evt)
    {
        print("R ");
    }
    private void LevelSkip(EventBase e)
    {
        loader.LoadScene(nextScene);
    }
    private void LevelFail(EventBase e)
    {
        loader.LoadScene(SceneLoader.SceneNames.LoseScene);
    }
    void Update()
    {
        
        if (Input.touchCount > 0)
        {

            if (Input.touches[0].phase == TouchPhase.Began)
            {
                // print(zoneL.worldBound.xMin +" " + zoneL.contentRect.xMax + " " + zoneL.contentRect.yMin + " " + zoneL.contentRect.yMax);
                // print(zoneR.contentRect);

     //           if (zoneL.ContainsPoint(zoneL.WorldToLocal(Input.touches[0].position)))
     //           {
     //               print("L ");// + Input.touches[0].position);
     //           }
     //           else if (zoneR.ContainsPoint(zoneR.WorldToLocal(Input.touches[0].position)))
     //           {
     //               print("R ");// + Input.touches[0].position);
     //           }
     //           else print("None ");// + Input.touches[0].position);
            }
        }
    }
}
