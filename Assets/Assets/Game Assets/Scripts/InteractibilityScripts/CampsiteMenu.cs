using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampsiteMenu : MonoBehaviour
{
    public GameObject Camp_Upgrade;


    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            Camp_Upgrade.SetActive(true);
            Debug.Log("Upgrade Time.");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            Camp_Upgrade.SetActive(false);
            Debug.Log("Done Upgrading.");
        }
    }
}
