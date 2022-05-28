using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Finish : MonoBehaviour
{
    public GameObject FinishUI;

    public PlayerMovement sound;

    public AudioSource Win;
    public ItemCollector item;

    [SerializeField] private TextMeshProUGUI diamondcount;

    public void isFinish()
    {
        sound.BGM.Pause();
        FinishUI.SetActive(true);
        Time.timeScale = 0f;
        Win.Play();
        diamondcount.text = "   x " + item.Diamond;
    }

    public void RestartUI(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }


}
