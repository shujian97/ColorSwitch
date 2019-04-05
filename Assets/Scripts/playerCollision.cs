using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCollision : MonoBehaviour
{
    private SpriteRenderer playerSpriter;
    public GameObject score;
    private TextMesh scoreText;

    private void Start()
    {
        scoreText = score.GetComponent<TextMesh>();
        PlayerPrefs.SetString("currentScore", "0");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //check if it collided with the obstacle
        if (collision.tag == "Obstacle")
        {
            if (collision.name != name)
            {
                PlayerPrefs.SetString("currentScore",scoreText.text);
                SceneManager.LoadScene("gameoverScene");
            }
        }
        else if (collision.tag == "ColorChanger")
        {
            Destroy(collision.gameObject);
            playerSpriter = GetComponent<SpriteRenderer>();
            //if the player is yellow
            if (name == "Yellow")
            {
                int ram = Random.Range(0, 3);
                switch (ram)
                {
                    case 0:
                        playerSpriter.color = new Color(1.000f, 0.000f, 0.000f);
                        name = "Red";
                        break;
                    case 1:
                        playerSpriter.color = new Color(1.000f, 0.000f, 1.000f);
                        name = "Magenta";
                        break;
                    case 2:
                        playerSpriter.color = new Color(0.000f, 1.000f, 1.000f);
                        name = "Cyan";
                        break;
                }
            }
            else if (name == "Red")
            {
                int ram = Random.Range(0, 3);
                switch (ram)
                {
                    case 0:
                        playerSpriter.color = new Color(1.000f, 1.000f, 0.000f);
                        name = "Yellow";
                        break;
                    case 1:
                        playerSpriter.color = new Color(1.000f, 0.000f, 1.000f);
                        name = "Magenta";
                        break;
                    case 2:
                        playerSpriter.color = new Color(0.000f, 1.000f, 1.000f);
                        name = "Cyan";
                        break;
                }
            }
            else if (name == "Cyan")
            {
                int ram = Random.Range(0, 3);
                switch (ram)
                {
                    case 0:
                        playerSpriter.color = new Color(1.000f, 0.000f, 0.000f);
                        name = "Red";
                        break;
                    case 1:
                        playerSpriter.color = new Color(1.000f, 0.000f, 1.000f);
                        name = "Magenta";
                        break;
                    case 2:
                        playerSpriter.color = new Color(1.000f, 1.000f, 0.000f);
                        name = "Yellow";
                        break;
                }

            }
            else if (name == "Magenta")
            {
                int ram = Random.Range(0, 3);
                switch (ram)
                {
                    case 0:
                        playerSpriter.color = new Color(1.000f, 0.000f, 0.000f);
                        name = "Red";
                        break;
                    case 1:
                        playerSpriter.color = new Color(1.000f, 1.000f, 0.000f);
                        name = "Yellow";
                        break;
                    case 2:
                        playerSpriter.color = new Color(0.000f, 1.000f, 1.000f);
                        name = "Cyan";
                        break;
                }
            }
        }

        //check if it collided with a point
        else if (collision.tag == "Point")
        {
            scoreText.text = System.Convert.ToString(System.Convert.ToInt32(scoreText.text) + 1);
            Destroy(collision.gameObject);
        }
        //check if it collided with a color changer
    }
}
