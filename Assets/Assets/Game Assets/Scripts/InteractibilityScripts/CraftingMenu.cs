using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingMenu : MonoBehaviour
{
    public GameObject Workbench_Upgrade;


    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            Workbench_Upgrade.SetActive(true);
            Debug.Log("Crafting Time.");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            Workbench_Upgrade.SetActive(false);
            Debug.Log("Done Crafting.");
        }
    }
}
