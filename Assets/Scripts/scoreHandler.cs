using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreHandler : MonoBehaviour
{
    public GameObject currentScore;
    public GameObject highScore;

    private TextMesh currentScoreText;
    private TextMesh highScoreText;

    private int current;
    private int high;
    // Start is called before the first frame update
    void Start()
    {
        currentScoreText = currentScore.GetComponent<TextMesh>();
        highScoreText = highScore.GetComponent<TextMesh>();

        currentScoreText.text = PlayerPrefs.GetString("currentScore");
        //Debug.Log(PlayerPrefs.GetString("currentScore"));
        //Debug.Log(System.Convert.ToInt32(PlayerPrefs.GetString("currentScore")));
        //string current1 = PlayerPrefs.GetString("currentScore");
        //current = System.Convert.ToInt32(current1);
        //string high1 = PlayerPrefs.GetString("highScore");
        //high = System.Convert.ToInt32(high1);
        
        current = System.Convert.ToInt32(PlayerPrefs.GetString("currentScore"));
        high = System.Convert.ToInt32(PlayerPrefs.GetString("highScore"));

        if (current > high)
        {
           PlayerPrefs.SetString("highScore", System.Convert.ToString(current));
        }
        highScoreText.text = PlayerPrefs.GetString("highScore");
        //highScoreText.text = System.Convert.ToString(high);
    }

}
