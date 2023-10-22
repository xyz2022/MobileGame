using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private List<GameObject> _doNotDestroyObjects;

    public enum SceneNames
    {
        TitleScene,
        Level1Scene,
        Level2Scene,
        Level3Scene,
        WinScene,
        LoseScene
    }

    //public static SceneNames nextScene;

    void Awake()
    {
        foreach(GameObject go in _doNotDestroyObjects)
        {
            DontDestroyOnLoad(go);
        }
        //nextScene = SceneNames.TitleScene;
        LoadScene(SceneNames.TitleScene);
    }

    IEnumerator LoadYourAsyncScene(SceneNames nextScene)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(nextScene.ToString());

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            print(asyncLoad.progress);
            yield return null;
        }
        print("LOADED SCENE: " + nextScene.ToString());
    }

    public void LoadScene(SceneNames nextScene)
    {
        StartCoroutine( LoadYourAsyncScene(nextScene));
    }
}
