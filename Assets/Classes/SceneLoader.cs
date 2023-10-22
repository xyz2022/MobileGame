using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private List<GameObject> _doNotDestroyObjects;
    private List<UnityEngine.SceneManagement.Scene> _sceneList;
    private int _currentScene;
    
    void Awake()
    {
        _sceneList = new List<Scene> ();
        _currentScene = 0;
        foreach(GameObject go in _doNotDestroyObjects)
        {
            DontDestroyOnLoad(go);
        }
        for(int i = 0; i < SceneManager.sceneCount; i++)
        {
            _sceneList.Add(SceneManager.GetSceneAt(i));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadNextScene()
    {
        if (_currentScene < _sceneList.Count)
        {
            _currentScene++;
            SceneManager.LoadScene(_sceneList[_currentScene].buildIndex);
        }
        else
            print("Its last scene");
    }
}
