using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ui2Script : MonoBehaviour
{
    [SerializeField] private SceneLoader.SceneNames nextScene;

    SceneLoader loader;

    void Start()
    {
        loader = FindObjectOfType<SceneLoader>();
        var root = GetComponent<UIDocument>().rootVisualElement;
        var button = root.Q<UnityEngine.UIElements.Button>("buttonInGameComplete");
        button.clickable.clickedWithEventInfo += B_clicked;
        //DontDestroyOnLoad(gameObject);
    }
    private void B_clicked(EventBase e)
    {
        Button button = (Button)e.target;
        print("Got: " + button.text);
        //SceneLoader.nextScene = SceneLoader.SceneNames.Level2Scene;
        loader.LoadScene(nextScene);
    }

}
