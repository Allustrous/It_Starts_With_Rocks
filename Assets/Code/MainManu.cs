using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManu : MonoBehaviour
{

// This loads a new scene
public void LoadScene(string sceneName) //so we can use it for multiple scenes
{
    SceneManager.LoadScene(sceneName);
}

public void Quit()
{
    Application.Quit();
    Debug.Log("Application has quit");
}

public void SwapPannel(GameObject selected)
{
    GameObject[] canvasList = GameObject.FindGameObjectsWithTag("UiCanvas");
    foreach(GameObject canvas in canvasList)
    {
        canvas.SetActive(false);
    }

    selected.SetActive(true);
}

}