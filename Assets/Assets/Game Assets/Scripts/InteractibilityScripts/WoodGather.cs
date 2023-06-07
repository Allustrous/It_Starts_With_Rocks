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
    float respawn = 0;
    float respawned = 0;


    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (respawned == 0)
        {
            if (collision.gameObject.tag == "Player")
            {
                gatheringCounter++;
                Debug.Log("WoodAxed");
            }
        }
        
    }

    void Start()
    {
    
    }

    void Update()
    {

        if(respawn == 1)
            {
                StartCoroutine("Spawner");
                Debug.Log("Respawning");
            }
        else if (respawn < 1)
            {
                Debug.Log("Spawned");
                StopCoroutine("Spawned");
            }
        if (gatheringCounter == 5)
            {
                Debug.Log("Gathered");
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
        Debug.Log("Spawned");
        Part1.SetActive(true);
        Part2.SetActive(true);
        Part3.SetActive(true);
        respawn = 0;
        respawned = 0;
        yield return null;
    }
    IEnumerator Resourcer ()
    {
        Debug.Log("Wood Packed");
        Part1.SetActive(false);
        Part2.SetActive(false);
        Part3.SetActive(false);
        resourcecounter.gatheredWood += 5;
        respawn = 1;
        respawned = 1;
        gatheringCounter = 0;
        yield return null;
    }

}