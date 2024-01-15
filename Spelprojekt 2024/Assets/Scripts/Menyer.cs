using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menyer : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
