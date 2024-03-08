using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public int[] _scenesIndexesToLoad;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel()
    {
        foreach (int sceneIndexes in _scenesIndexesToLoad)
        {
            SceneManager.LoadScene(sceneIndexes, LoadSceneMode.Single);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void action_Menu()
    {
        SceneManager.LoadScene("Scenes/GameOver");
    }
}
