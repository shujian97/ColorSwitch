using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerDemo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("The object has entered the trigger");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("The object has left the trigger");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("The object is staying");
    }
}
