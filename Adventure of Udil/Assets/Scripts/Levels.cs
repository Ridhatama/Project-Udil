using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    public void level1()
    {
        SceneManager.LoadScene("Lv1");
    }

    public void level2()
    {
        SceneManager.LoadScene("Lv2");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
