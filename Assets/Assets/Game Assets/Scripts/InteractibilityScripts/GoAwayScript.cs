using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoAwayScript : MonoBehaviour
{
    public GameObject Part1;
    public GameObject Part2;
    public GameObject Part3;
    public GameObject Part4;
    public GameObject Part5;
    public GameObject Part6;
    public GameObject Part7;
    public GameObject Part8;
    public GameObject Part9;
    
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Camera")
        {
            Part1.SetActive(false);
            Part2.SetActive(false);
            Part3.SetActive(false);
            Part4.SetActive(false);
            Part5.SetActive(false);
            Part6.SetActive(false);
            Part7.SetActive(false);
            Part8.SetActive(false);
            Part9.SetActive(false);
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Camera")
        {
            Part1.SetActive(true);
            Part2.SetActive(true);
            Part3.SetActive(true);
            Part4.SetActive(true);
            Part5.SetActive(true);
            Part6.SetActive(true);
            Part7.SetActive(true);
            Part8.SetActive(true);
            Part9.SetActive(true);
        }
    }
}
