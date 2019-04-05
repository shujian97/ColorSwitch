using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reloadbuttonScript : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("playScene");
    }
}
