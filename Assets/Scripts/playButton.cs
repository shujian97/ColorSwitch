using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour
{
    //change scene when button is pressed.

    private void OnMouseDown()
    {
        PlayerPrefs.SetString("highScore", "0");
        SceneManager.LoadScene("playScene");
    }
}
