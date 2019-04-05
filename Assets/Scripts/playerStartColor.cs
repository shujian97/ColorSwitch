using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStartColor : MonoBehaviour
{
    private SpriteRenderer playerSprite;

    public void startColorChanger()
    {
        int ram = Random.Range(0, 4);
        playerSprite = GetComponent<SpriteRenderer>();
        switch (ram)
        {
            case 0:
                //ram ==0
                playerSprite.color = new Color(1.000f,0.000f,0.000f);
                name = "Red";
                break;
            case 1:
                //ram ==1
                playerSprite.color = new Color(1.000f, 1.000f, 0.000f);
                name = "Yellow";
                break;
            case 2:
                //ram ==2
                playerSprite.color = new Color(1.000f, 0.000f, 1.000f);
                name = "Magenta";
                break;
            case 3:
                //ram ==3
                playerSprite.color = new Color(0.000f, 1.000f, 1.000f);
                name = "Cyan";
                break;

        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        startColorChanger();
    }
    
}
