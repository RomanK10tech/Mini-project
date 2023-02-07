using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void Scenes(int NumberScenes)
    {
        SceneManager.LoadScene(NumberScenes);
    }

    public void Quit()
    {
        Application.Quit();
    }
}