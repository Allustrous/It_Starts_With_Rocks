using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodGather : MonoBehaviour
{
    public ResourceCounter resourcecounter;
    public Equipment equipment;
    public GameObject Part1;
    public GameObject Part2;
    public GameObject Part3;
    public float gatheringCounter = 0;
    float respawned = 0;
    int gatheredResource = 5;


    private void OnCollisionEnter(Collision collision)
    {
        if (respawned == 0)
        {
            if (collision.gameObject.tag == "Wood")
            {
                gatheringCounter++;
            }
            if (gatheringCounter == 5)
            {
                StartCoroutine("Resourcer");
                StartCoroutine("Spawner");
                StartCoroutine("CodingSucks");
                respawned = 1;
            }
            else if (gatheringCounter == 0)
            {
                respawned = 0;
                StopCoroutine("Spawner");
                StopCoroutine("Resourcer");
                StopCoroutine("CodingSucks");
            }
        }

        if (collision.gameObject.tag == "Camera")
        {
            Part1.SetActive(false);
            Part2.SetActive(false);
            Part3.SetActive(false);
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Camera")
        {
            Part1.SetActive(true);
            Part2.SetActive(true);
            Part3.SetActive(true);
        }
    }

    void Start()
    {
    
    }

    void Update()
    {
        if (gatheringCounter > 5)
        {
            gatheringCounter = 0;
        }
        if (equipment.axeTier == 1)
        {
            Debug.Log("Axe Tier 1");
            gatheredResource = 5;
        }
        if (equipment.axeTier == 2)
        {
            Debug.Log("Axe Tier 2");
            gatheredResource = 10;
        }
        if (equipment.axeTier == 3)
        {
            Debug.Log("Axe Tier 3");
            gatheredResource = 10;
        }


        if (gatheringCounter == 0)
            {
                respawned = 0;
                StopCoroutine("Spawner");
                StopCoroutine("Resourcer");
                StopCoroutine("CodingSucks");
            }
    }

    IEnumerator Spawner ()
    {
        yield return new WaitForSeconds(5);
        Part1.SetActive(true);
        Part2.SetActive(true);
        Part3.SetActive(true);
        
        
    }
    IEnumerator Resourcer ()
    {
        resourcecounter.gatheredWood += gatheredResource;
        Part1.SetActive(false);
        Part2.SetActive(false);
        Part3.SetActive(false);
        
        yield return new WaitForSeconds(1);
    }

     IEnumerator CodingSucks ()
     {
        yield return new WaitForSeconds(5);
        gatheringCounter = 0;
     }



}