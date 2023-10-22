using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private int _currentScene;
    
    private List<Scene> _sceneList;
    [SerializeField] private List<GameObject> _doNotDestroyObjects;
    // Start is called before the first frame update
    void Awake()
    {
        _currentScene = 0;
        foreach(GameObject go in _doNotDestroyObjects)
        {
            DontDestroyOnLoad(go);
        }
        foreach(Scene scene in _sceneList)
        {
            _sceneList.Add(scene);
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
