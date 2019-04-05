using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleCloner : MonoBehaviour
{
    public GameObject colorChangerPrefab;
    public GameObject colorChangerSpawnPoint;

    public GameObject pointPrefab;

    public GameObject smallCirclePrefab;
    public GameObject smallCircleSpawnPoint;


    //public GameObject smallSquarePrefab;
    //public GameObject smallSquareSpawnPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Spawn")
        {
            //clone obstacle
            //int ram = Random.Range(0, 2);
            //if (ram == 0)
            //{
            Instantiate(smallCirclePrefab, smallCircleSpawnPoint.transform.position, smallCircleSpawnPoint.transform.rotation);
            Instantiate(colorChangerPrefab,colorChangerSpawnPoint.transform.position,colorChangerPrefab.transform.rotation);
            Instantiate(pointPrefab,smallCircleSpawnPoint.transform.position, smallCircleSpawnPoint.transform.rotation);
            //}
            //else if(ram == 1)
            //{
            //    Instantiate(smallSquarePrefab, smallSquareSpawnPoint.transform.position, smallSquareSpawnPoint.transform.rotation);
            //}
        }
    }
  
}
