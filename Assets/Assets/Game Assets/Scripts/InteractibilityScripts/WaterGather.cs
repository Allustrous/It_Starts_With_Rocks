using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaterGather : MonoBehaviour
{
    public ResourceCounter resourcecounter;
    int gatheredResource = 5;
    float InWater = 1;
    float timeValue = 75;
    int timeNow;
    public float WaterLevel = 1;


    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            InWater = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        { 
            InWater = 1;
            timeValue = 75;
        }
    }

    void Start()
    {
    
    }

    void Update()
    {
        if (InWater == 0)
        {
            if(timeValue > 0)
            {
                timeValue -= Time.deltaTime;
                timeNow = (int)timeValue;
            }

            if (timeNow == 75)
            {
                WaterLevel = 1;
            }
            else if (timeNow == 60)
            {
                WaterLevel = 2;
            }
            else if (timeNow == 45)
            {
                WaterLevel = 3;
            }
            else if (timeNow == 30)
            {
                WaterLevel = 4;
            }
            else if (timeNow == 15)
            {
                WaterLevel = 5;
            }




            if(WaterLevel < 6)
            {
                if (WaterLevel == 0)
                {
                    resourcecounter.gatheredWater = 0;
                }
                else if (WaterLevel == 1)
                {
                    resourcecounter.gatheredWater = 5;
                }
                else if (WaterLevel == 2)
                {
                    resourcecounter.gatheredWater = 10;
                }
                else if (WaterLevel == 3)
                {
                    resourcecounter.gatheredWater = 15;
                }
                else if (WaterLevel == 4)
                {
                    resourcecounter.gatheredWater = 20;
                }
                else if (WaterLevel == 5)
                {
                    resourcecounter.gatheredWater = 25;
                }
                
            }
        }
    }
}