using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CampsiteDeposit : MonoBehaviour
{
    public WaterGather watergather;
    public ResourceCounter resourcecounter;
    public TextMeshProUGUI campStoneTXT;
    public int campStone = 0;
    public TextMeshProUGUI campWoodTXT;
    public int campWood = 0;
    public TextMeshProUGUI campFiberTXT;
    public int campFiber = 0;
    public TextMeshProUGUI campLeatherTXT;
    public int campLeather = 0;
    public TextMeshProUGUI campFoodTXT;
    public int campFood = 50;
    public TextMeshProUGUI campWaterTXT;
    public int campWater = 50;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            campStone += resourcecounter.gatheredStone;
            resourcecounter.gatheredStone = 0;
            campWood += resourcecounter.gatheredWood;
            resourcecounter.gatheredWood = 0;
            campFiber += resourcecounter.gatheredFiber;
            resourcecounter.gatheredFiber = 0;
            campLeather += resourcecounter.gatheredLeather;
            resourcecounter.gatheredLeather = 0;
            campFood += resourcecounter.gatheredFood;
            resourcecounter.gatheredFood = 0;
            campWater += resourcecounter.gatheredWater;
            resourcecounter.gatheredWater = 0;
            watergather.WaterLevel = 0;
            Debug.Log("Resources Deposited!");
        }
    }

     void Update()
    {
        campStoneTXT.SetText("Stone: " + campStone.ToString());
        campWoodTXT.SetText("Wood: " + campWood.ToString());
        campFiberTXT.SetText("Fiber: " + campFiber.ToString());
        campLeatherTXT.SetText("Leather: " + campLeather.ToString());
        campFoodTXT.SetText("Food: " + campFood.ToString());
        campWaterTXT.SetText("Water: " + campWater.ToString());
    }
}
