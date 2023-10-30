using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class ui1Script : MonoBehaviour
{
    [SerializeField] private SceneLoader.SceneNames nextScene;
    SceneLoader loader;


    void Start()
    {
        loader = FindObjectOfType<SceneLoader>();
        var root = GetComponent<UIDocument>().rootVisualElement;
        var button = root.Q<UnityEngine.UIElements.Button>("buttonTitleStart");
        button.clickable.clickedWithEventInfo += B_clicked;
        


    }

    private void B_clicked(EventBase e)
    {
        Button button = (Button)e.target;
        print("Got: " + button.text);
        button.SetEnabled(false);
        //SceneLoader.nextScene = SceneLoader.SceneNames.Level1Scene;
        loader.LoadScene(nextScene);
    }

    private void Update()
    {

    }
}
