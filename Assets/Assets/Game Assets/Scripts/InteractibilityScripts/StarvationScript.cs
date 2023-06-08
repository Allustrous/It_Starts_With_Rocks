using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarvationScript : MonoBehaviour
{
    public ResourceCounter resourcecounter;
    public CampsiteDeposit campsitedeposit;
    float FoodLevel = 3;
    float WaterLevel = 5;
    float HealthLevel = 8;
    float AtCamp = 0;

    public GameObject Hunger1;
    public GameObject Hunger2;
    public GameObject Hunger3;
    public GameObject Thirst0;
    public GameObject Thirst1;
    public GameObject Thirst2;
    public GameObject Thirst3;
    public GameObject Thirst4;
    public GameObject Thirst5;
    public GameObject Health1;
    public GameObject Health2;
    public GameObject Health3;
    public GameObject Health4;
    public GameObject Health5;
    public GameObject Health6;
    public GameObject Health7;
    public GameObject Health8;

    float timeValue = 180;
    int timeNow;
    float timeHealth = 20;
    int timeNowHealth;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        timeNow = (int)timeValue;
        timeNowHealth = (int)timeHealth;

        Debug.Log("Water: " + WaterLevel);
        Debug.Log("Food: " + FoodLevel);
        Debug.Log("Time: " + timeNow);
        Debug.Log("Health Time: " + timeNowHealth);
        Debug.Log("Health: " + HealthLevel);

        

        if (AtCamp == 0)
        {
            // water
            if(campsitedeposit.campWater > 0 & campsitedeposit.campFood > 0)
            {
                if (WaterLevel == 0)
                {
                    timeValue = 180;
                    timeHealth = 20;
                    WaterLevel = 5;
                    campsitedeposit.campWater -= 10;
                }
                else if (WaterLevel == 1)
                {
                    timeValue = 180;
                    timeHealth = 20;
                    WaterLevel = 5;
                    campsitedeposit.campWater -= 8;
                }
                else if (WaterLevel == 2)
                {
                    timeValue = 180;
                    timeHealth = 20;
                    WaterLevel = 5;
                    campsitedeposit.campWater -= 6;
                }
                else if (WaterLevel == 3)
                {
                    timeValue = 180;
                    timeHealth = 20;
                    WaterLevel = 5;
                    campsitedeposit.campWater -= 4;
                }
                else if (WaterLevel == 4)
                {
                    timeValue = 180;
                    timeHealth = 20;
                    WaterLevel = 5;
                    campsitedeposit.campWater -= 2;
                }
                else if (WaterLevel == 5)
                {
                    timeValue = 180;
                    timeHealth = 20;
                    WaterLevel = 5;
                }
                
            }
            else
                {
                    if (timeValue > 0)
                    {
                        if (campsitedeposit.campFood <= 0 || campsitedeposit.campWater <= 0)
                        {
                            timeValue -= Time.deltaTime;
                        }
                    }
                }

            
            

            // food

            if(campsitedeposit.campFood > 0 & campsitedeposit.campWater > 0)
            {
                if (FoodLevel == 0)
                {
                    timeValue = 180;
                    timeHealth = 20;
                    FoodLevel = 3;
                    campsitedeposit.campFood -= 10;
                }
                else if (FoodLevel == 1)
                {
                    timeValue = 180;
                    timeHealth = 20;
                    FoodLevel = 3;
                    campsitedeposit.campFood -= 7;
                }
                else if (FoodLevel == 2)
                {
                    timeValue = 180;
                    timeHealth = 20;
                    FoodLevel = 3;
                    campsitedeposit.campFood -= 3;
                }
                else if (FoodLevel == 3)
                {
                    timeValue = 180;
                    timeHealth = 20;
                    FoodLevel = 3;
                }
                
            }
            else
                {
                    if (timeValue > 0)
                    {
                        if (campsitedeposit.campFood <= 0 || campsitedeposit.campWater <= 0)
                        {
                            timeValue -= Time.deltaTime;
                        }
                    }
                }
            
            
        }
        else if (AtCamp == 1)
        {
            if (timeNowHealth > 0)
            {
                if (timeNowHealth == 1)
                {
                    Health1.SetActive(false);
                    Health2.SetActive(false);
                    Health3.SetActive(false);
                    Health4.SetActive(false);
                    Health5.SetActive(false);
                    Health6.SetActive(false);
                    Health7.SetActive(false);
                    Health8.SetActive(false);
                    HealthLevel = 0;
                }
                else if (timeNowHealth == 2)
                {
                    Health1.SetActive(true);
                    Health2.SetActive(false);
                    Health3.SetActive(false);
                    Health4.SetActive(false);
                    Health5.SetActive(false);
                    Health6.SetActive(false);
                    Health7.SetActive(false);
                    Health8.SetActive(false);
                    HealthLevel = 1;
                }
                else if (timeNowHealth == 5)
                {
                    Health1.SetActive(true);
                    Health2.SetActive(true);
                    Health3.SetActive(false);
                    Health4.SetActive(false);
                    Health5.SetActive(false);
                    Health6.SetActive(false);
                    Health7.SetActive(false);
                    Health8.SetActive(false);
                    HealthLevel = 2;
                }
                else if (timeNowHealth == 7)
                {
                    Health1.SetActive(true);
                    Health2.SetActive(true);
                    Health3.SetActive(true);
                    Health4.SetActive(false);
                    Health5.SetActive(false);
                    Health6.SetActive(false);
                    Health7.SetActive(false);
                    Health8.SetActive(false);
                    HealthLevel = 3;
                }
                else if (timeNowHealth == 10)
                {
                    Health1.SetActive(true);
                    Health2.SetActive(true);
                    Health3.SetActive(true);
                    Health4.SetActive(true);
                    Health5.SetActive(false);
                    Health6.SetActive(false);
                    Health7.SetActive(false);
                    Health8.SetActive(false);
                    HealthLevel = 4;
                }
                else if (timeNowHealth == 12)
                {
                    Health1.SetActive(true);
                    Health2.SetActive(true);
                    Health3.SetActive(true);
                    Health4.SetActive(true);
                    Health5.SetActive(false);
                    Health6.SetActive(false);
                    Health7.SetActive(false);
                    Health8.SetActive(false);
                    HealthLevel = 5;
                }
                else if (timeNowHealth == 15)
                {
                    Health1.SetActive(true);
                    Health2.SetActive(true);
                    Health3.SetActive(true);
                    Health4.SetActive(true);
                    Health5.SetActive(true);
                    Health6.SetActive(true);
                    Health7.SetActive(false);
                    Health8.SetActive(false);
                    HealthLevel = 6;
                }
                else if (timeNowHealth == 17)
                {
                    Health1.SetActive(true);
                    Health2.SetActive(true);
                    Health3.SetActive(true);
                    Health4.SetActive(true);
                    Health5.SetActive(true);
                    Health6.SetActive(true);
                    Health7.SetActive(true);
                    Health8.SetActive(false);
                    HealthLevel = 7;
                }
                else if (timeNowHealth == 20)
                {
                    Health1.SetActive(true);
                    Health2.SetActive(true);
                    Health3.SetActive(true);
                    Health4.SetActive(true);
                    Health5.SetActive(true);
                    Health6.SetActive(true);
                    Health7.SetActive(true);
                    Health8.SetActive(true);
                    HealthLevel = 8;
                }
            }


            if (timeValue > 0)
            {
                timeValue -= Time.deltaTime;
            }
            if (WaterLevel > 0)
            {
                if (timeNow == 144)
                {
                    WaterLevel = 4;
                    Thirst0.SetActive(false);
                    Thirst1.SetActive(false);
                    Thirst2.SetActive(false);
                    Thirst3.SetActive(false);
                    Thirst4.SetActive(true);
                    Thirst5.SetActive(false);
                }
                else if (timeNow == 108)
                {
                    WaterLevel = 3;
                    Thirst0.SetActive(false);
                    Thirst1.SetActive(false);
                    Thirst2.SetActive(false);
                    Thirst3.SetActive(true);
                    Thirst4.SetActive(false);
                    Thirst5.SetActive(false);
                }
                else if (timeNow == 72)
                {
                    WaterLevel = 2;
                    Thirst0.SetActive(false);
                    Thirst1.SetActive(false);
                    Thirst2.SetActive(true);
                    Thirst3.SetActive(false);
                    Thirst4.SetActive(false);
                    Thirst5.SetActive(false);
                }
                else if (timeNow == 36)
                {
                    WaterLevel = 1;
                    Thirst0.SetActive(false);
                    Thirst1.SetActive(true);
                    Thirst2.SetActive(false);
                    Thirst3.SetActive(false);
                    Thirst4.SetActive(false);
                    Thirst5.SetActive(false);
                }
                else if (timeNow == 1)
                {
                    WaterLevel = 0;
                    Thirst0.SetActive(true);
                    Thirst1.SetActive(false);
                    Thirst2.SetActive(false);
                    Thirst3.SetActive(false);
                    Thirst4.SetActive(false);
                    Thirst5.SetActive(false);
                }
                else if (timeNow == 180)
                {
                    WaterLevel = 5;
                    Thirst0.SetActive(false);
                    Thirst1.SetActive(false);
                    Thirst2.SetActive(false);
                    Thirst3.SetActive(false);
                    Thirst4.SetActive(false);
                    Thirst5.SetActive(true);
                }
            }
            if (WaterLevel == 0)
            {
                if(timeHealth > 0)
                {
                    timeHealth -= Time.deltaTime;
                }
                
            }
            if (FoodLevel > 0)
            {
                if (timeNow == 120)
                {
                    FoodLevel = 2;
                    Hunger1.SetActive(true);
                    Hunger2.SetActive(true);
                    Hunger3.SetActive(false);

                }
                else if (timeNow == 60)
                {
                    FoodLevel = 1;
                    Hunger1.SetActive(true);
                    Hunger2.SetActive(false);
                    Hunger3.SetActive(false);
                }
                else if (timeNow == 1)
                {
                    FoodLevel = 0;
                    Hunger1.SetActive(false);
                    Hunger2.SetActive(false);
                    Hunger3.SetActive(false);
                    timeHealth -= Time.deltaTime;
                }
                else if (timeNow == 180)
                {
                    FoodLevel = 3;
                    Hunger1.SetActive(true);
                    Hunger2.SetActive(true);
                    Hunger3.SetActive(true);
                }
            }
            if (FoodLevel == 0)
            {
                if(timeHealth > 0)
                {
                    timeHealth -= Time.deltaTime;
                }
            }
        }
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            AtCamp = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        { 
            AtCamp = 1;
        }
    }

}
