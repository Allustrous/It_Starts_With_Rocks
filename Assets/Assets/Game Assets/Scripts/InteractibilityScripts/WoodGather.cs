using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodGather : MonoBehaviour
{
    public ResourceCounter resourcecounter;
    public GameObject Part1;
    public GameObject Part2;
    public GameObject Part3;
    public float gatheringCounter = 0;
    float respawned = 0;


    private void OnCollisionEnter(Collision collision)
    {
        if (respawned == 0)
        {
            if (collision.gameObject.tag == "Player")
            {
                gatheringCounter++;
            }
        }

        if (collision.gameObject.tag == "Camera")
        {
            Part1.SetActive(false);
            Part2.SetActive(false);
            Part3.SetActive(false);
        }

        if (gatheringCounter == 5)
            {
                StartCoroutine("Resourcer");
                StartCoroutine("Spawner");
                respawned = 1;
            }
        else if (gatheringCounter == 0)
            {
                respawned = 0;
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
    }

    IEnumerator Spawner ()
    {
        yield return new WaitForSeconds(5);
        gatheringCounter = 0;
        Part1.SetActive(true);
        Part2.SetActive(true);
        Part3.SetActive(true);
        StopCoroutine("Spawner");
        
    }
    IEnumerator Resourcer ()
    {
        resourcecounter.gatheredWood += 5;
        Part1.SetActive(false);
        Part2.SetActive(false);
        Part3.SetActive(false);
        StopCoroutine("Resourcer");
        yield return new WaitForSeconds(1);
    }



}