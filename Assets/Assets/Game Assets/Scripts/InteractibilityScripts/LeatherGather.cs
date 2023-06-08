using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LeatherGather : MonoBehaviour
{
    public ResourceCounter resourcecounter;
    public Equipment equipment;
    public GameObject Part1;
    public float gatheringCounter = 0;
    float respawn = 0;
    float respawned = 0;
    int gatheredResource = 5;


    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (respawned == 0)
        {
            if (collision.gameObject.tag == "Leather")
            {
                gatheringCounter++;
                
            }
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


        if (equipment.spearTier == 1)
        {
            gatheredResource = 5;
        }
        else if (equipment.spearTier == 2)
        {
            gatheredResource = 10;
        }
        else if (equipment.spearTier == 3)
        {
            gatheredResource = 20;
        }

        if(respawn == 1)
            {
                StartCoroutine("Spawner");
                
            }
        else if (respawn < 1)
            {
                StopCoroutine("Spawned");
            }
        if (gatheringCounter == 5)
            {
                StartCoroutine("Resourcer");
            }
        else if (gatheringCounter == 0)
        {
            StopCoroutine("Resourcer");
        }

    }

    IEnumerator Spawner ()
    {
        yield return new WaitForSeconds(5);
        Part1.SetActive(true);
        respawn = 0;
        respawned = 0;
        yield return null;
    }
    IEnumerator Resourcer ()
    {
        Part1.SetActive(false);
        resourcecounter.gatheredLeather += gatheredResource;
        respawn = 1;
        respawned = 1;
        gatheringCounter = 0;
        yield return null;
    }

}