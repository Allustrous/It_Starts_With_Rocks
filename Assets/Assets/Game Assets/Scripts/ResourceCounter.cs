using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourceCounter : MonoBehaviour
{
    public TextMeshProUGUI InventoryStone;
    public int gatheredStone = 0;
    public TextMeshProUGUI InventoryWood;
    public int gatheredWood = 0;
    public TextMeshProUGUI InventoryFiber;
    public int gatheredFiber = 0;
    public TextMeshProUGUI InventoryLeather;
    public int gatheredLeather = 0;
    public TextMeshProUGUI InventoryFood;
    public int gatheredFood = 0;
    public TextMeshProUGUI InventoryWater;
    public int gatheredWater = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InventoryStone.SetText("Stone: " + gatheredStone.ToString());
        InventoryWood.SetText("Wood: " + gatheredWood.ToString());
        InventoryFiber.SetText("Fiber: " + gatheredFiber.ToString());
        InventoryLeather.SetText("Leather: " + gatheredLeather.ToString());
        InventoryFood.SetText("Food: " + gatheredFood.ToString());
        InventoryWater.SetText("Water: " + gatheredWater.ToString());

    }
}
