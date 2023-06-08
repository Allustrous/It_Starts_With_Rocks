using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarvationScript : MonoBehaviour
{

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

    float timeValue = 20;
    int timeNow;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        timeNow = (int)timeValue;

        Debug.Log("Water: " + WaterLevel);
        Debug.Log("Food: " + FoodLevel);
        Debug.Log("Time: " + timeNow);

        

        

        if (AtCamp == 0)
        {
            timeValue = 20;
        }
        else if (AtCamp == 1)
        {
            if (timeValue > 0)
            {
                timeValue -= Time.deltaTime;
            }
            
            if (WaterLevel > 0)
            {
                if (timeNow == 7)
                {
                    WaterLevel = 4;
                }
                else if (timeNow == 4)
                {
                    WaterLevel = 3;
                }
                else if (timeNow == 3)
                {
                    WaterLevel = 2;
                }
                else if (timeNow == 2)
                {
                    WaterLevel = 1;
                }
                else if (timeNow == 1)
                {
                    WaterLevel = 0;
                }
                else
                {
                    WaterLevel = 5;
                }
            }
            if (FoodLevel > 0)
            {
                if (timeNow == 7)
                {
                    FoodLevel = 2;
                }
                if (timeNow == 4)
                {
                    FoodLevel = 1;
                }
                if (timeNow == 1)
                {
                    FoodLevel = 0;
                }
                else
                {
                    FoodLevel = 3;
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

    IEnumerator StarveCheck()
    {
        // Food
        if (FoodLevel == 3)
        {
            Hunger1.SetActive(true);
            Hunger2.SetActive(true);
            Hunger3.SetActive(true);
            StopCoroutine("Starving");
            Debug.Log(FoodLevel);
        }
        else if (FoodLevel == 2)
        {
            Hunger1.SetActive(true);
            Hunger2.SetActive(true);
            Hunger3.SetActive(false);
            StopCoroutine("Starving");
            Debug.Log(FoodLevel);
        }
        else if (FoodLevel == 1)
        {
            Hunger1.SetActive(true);
            Hunger2.SetActive(false);
            Hunger3.SetActive(false);
            StopCoroutine("Starving");
            Debug.Log(FoodLevel);
        }
        else if (FoodLevel == 0)
        {
            Hunger1.SetActive(false);
            Hunger2.SetActive(false);
            Hunger3.SetActive(false);
            StartCoroutine("Starving");
            Debug.Log(FoodLevel);
        }

        // Water
        if (WaterLevel == 5)
        {
            Thirst0.SetActive(false);
            Thirst1.SetActive(false);
            Thirst2.SetActive(false);
            Thirst3.SetActive(false);
            Thirst4.SetActive(false);
            Thirst5.SetActive(true);
            StopCoroutine("Dehydrating");
            Debug.Log(WaterLevel);
        }
        else if (WaterLevel == 4)
        {
            Thirst0.SetActive(false);
            Thirst1.SetActive(false);
            Thirst2.SetActive(false);
            Thirst3.SetActive(false);
            Thirst4.SetActive(true);
            Thirst5.SetActive(false);
            StopCoroutine("Dehydrating");
            Debug.Log(WaterLevel);
        }
        else if (WaterLevel == 3)
        {
            Thirst0.SetActive(false);
            Thirst1.SetActive(false);
            Thirst2.SetActive(false);
            Thirst3.SetActive(true);
            Thirst4.SetActive(false);
            Thirst5.SetActive(false);
            StopCoroutine("Dehydrating");
            Debug.Log(WaterLevel);
        }
        else if (WaterLevel == 2)
        {
            Thirst0.SetActive(false);
            Thirst1.SetActive(false);
            Thirst2.SetActive(true);
            Thirst3.SetActive(false);
            Thirst4.SetActive(false);
            Thirst5.SetActive(false);
            StopCoroutine("Dehydrating");
            Debug.Log(WaterLevel);
        }
        else if (WaterLevel == 1)
        {
            Thirst0.SetActive(false);
            Thirst1.SetActive(true);
            Thirst2.SetActive(false);
            Thirst3.SetActive(false);
            Thirst4.SetActive(false);
            Thirst5.SetActive(false);
            StopCoroutine("Dehydrating");
            Debug.Log(WaterLevel);
        }
        else if (WaterLevel == 0)
        {
            Thirst0.SetActive(true);
            Thirst1.SetActive(false);
            Thirst2.SetActive(false);
            Thirst3.SetActive(false);
            Thirst4.SetActive(false);
            Thirst5.SetActive(false);
            StartCoroutine("Dehydrating");
            Debug.Log(WaterLevel);
        }

        // return
        yield return new WaitForSeconds(1);
    }

    IEnumerator Starving()
    {
        if (HealthLevel == 0)
        {
            Health1.SetActive(false);
            Health2.SetActive(false);
            Health3.SetActive(false);
            Health4.SetActive(false);
            Health5.SetActive(false);
            Health6.SetActive(false);
            Health7.SetActive(false);
            Health8.SetActive(false);
        }
        else if (HealthLevel == 1)
        {
            Health1.SetActive(true);
            Health2.SetActive(false);
            Health3.SetActive(false);
            Health4.SetActive(false);
            Health5.SetActive(false);
            Health6.SetActive(false);
            Health7.SetActive(false);
            Health8.SetActive(false);
        }
        else if (HealthLevel == 2)
        {
            Health1.SetActive(true);
            Health2.SetActive(true);
            Health3.SetActive(false);
            Health4.SetActive(false);
            Health5.SetActive(false);
            Health6.SetActive(false);
            Health7.SetActive(false);
            Health8.SetActive(false);
        }
        else if (HealthLevel == 3)
        {
            Health1.SetActive(true);
            Health2.SetActive(true);
            Health3.SetActive(true);
            Health4.SetActive(false);
            Health5.SetActive(false);
            Health6.SetActive(false);
            Health7.SetActive(false);
            Health8.SetActive(false);
        }
        else if (HealthLevel == 4)
        {
            Health1.SetActive(true);
            Health2.SetActive(true);
            Health3.SetActive(true);
            Health4.SetActive(true);
            Health5.SetActive(false);
            Health6.SetActive(false);
            Health7.SetActive(false);
            Health8.SetActive(false);
        }
        else if (HealthLevel == 5)
        {
            Health1.SetActive(true);
            Health2.SetActive(true);
            Health3.SetActive(true);
            Health4.SetActive(true);
            Health5.SetActive(false);
            Health6.SetActive(false);
            Health7.SetActive(false);
            Health8.SetActive(false);
        }
        else if (HealthLevel == 6)
        {
            Health1.SetActive(true);
            Health2.SetActive(true);
            Health3.SetActive(true);
            Health4.SetActive(true);
            Health5.SetActive(true);
            Health6.SetActive(true);
            Health7.SetActive(false);
            Health8.SetActive(false);
        }
        else if (HealthLevel == 7)
        {
            Health1.SetActive(true);
            Health2.SetActive(true);
            Health3.SetActive(true);
            Health4.SetActive(true);
            Health5.SetActive(true);
            Health6.SetActive(true);
            Health7.SetActive(true);
            Health8.SetActive(false);
        }
        else if (HealthLevel == 8)
        {
            Health1.SetActive(true);
            Health2.SetActive(true);
            Health3.SetActive(true);
            Health4.SetActive(true);
            Health5.SetActive(true);
            Health6.SetActive(true);
            Health7.SetActive(true);
            Health8.SetActive(true);
        }
        yield return new WaitForSeconds(1);
    }

    IEnumerator Dehydrating()
    {
        if (HealthLevel == 0)
        {
            Health1.SetActive(false);
            Health2.SetActive(false);
            Health3.SetActive(false);
            Health4.SetActive(false);
            Health5.SetActive(false);
            Health6.SetActive(false);
            Health7.SetActive(false);
            Health8.SetActive(false);
        }
        else if (HealthLevel == 1)
        {
            Health1.SetActive(true);
            Health2.SetActive(false);
            Health3.SetActive(false);
            Health4.SetActive(false);
            Health5.SetActive(false);
            Health6.SetActive(false);
            Health7.SetActive(false);
            Health8.SetActive(false);
        }
        else if (HealthLevel == 2)
        {
            Health1.SetActive(true);
            Health2.SetActive(true);
            Health3.SetActive(false);
            Health4.SetActive(false);
            Health5.SetActive(false);
            Health6.SetActive(false);
            Health7.SetActive(false);
            Health8.SetActive(false);
        }
        else if (HealthLevel == 3)
        {
            Health1.SetActive(true);
            Health2.SetActive(true);
            Health3.SetActive(true);
            Health4.SetActive(false);
            Health5.SetActive(false);
            Health6.SetActive(false);
            Health7.SetActive(false);
            Health8.SetActive(false);
        }
        else if (HealthLevel == 4)
        {
            Health1.SetActive(true);
            Health2.SetActive(true);
            Health3.SetActive(true);
            Health4.SetActive(true);
            Health5.SetActive(false);
            Health6.SetActive(false);
            Health7.SetActive(false);
            Health8.SetActive(false);
        }
        else if (HealthLevel == 5)
        {
            Health1.SetActive(true);
            Health2.SetActive(true);
            Health3.SetActive(true);
            Health4.SetActive(true);
            Health5.SetActive(false);
            Health6.SetActive(false);
            Health7.SetActive(false);
            Health8.SetActive(false);
        }
        else if (HealthLevel == 6)
        {
            Health1.SetActive(true);
            Health2.SetActive(true);
            Health3.SetActive(true);
            Health4.SetActive(true);
            Health5.SetActive(true);
            Health6.SetActive(true);
            Health7.SetActive(false);
            Health8.SetActive(false);
        }
        else if (HealthLevel == 7)
        {
            Health1.SetActive(true);
            Health2.SetActive(true);
            Health3.SetActive(true);
            Health4.SetActive(true);
            Health5.SetActive(true);
            Health6.SetActive(true);
            Health7.SetActive(true);
            Health8.SetActive(false);
        }
        else if (HealthLevel == 8)
        {
            Health1.SetActive(true);
            Health2.SetActive(true);
            Health3.SetActive(true);
            Health4.SetActive(true);
            Health5.SetActive(true);
            Health6.SetActive(true);
            Health7.SetActive(true);
            Health8.SetActive(true);
        }
        yield return new WaitForSeconds(1);
    }
}
