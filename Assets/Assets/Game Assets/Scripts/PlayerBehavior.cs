using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{

    
    public float speed = 4f;
    float jumpHeight = 800;
    Rigidbody rb;
    public GameObject Player;

    // Update is called once per frame

    void Start () {
        StartCoroutine(Controls());
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        //Up/down arrow keys
        float vertical =Input.GetAxis("Vertical");
       

        //left/right keys
        float horizontal =Input.GetAxis("Horizontal");

        //Gruping everything in one vector
        Vector3 motion12Vector = new Vector3(0, 0, vertical);
        

        transform.Translate(motion12Vector *speed *Time.deltaTime);
        
        if (Input.GetKey("w"))
        {
            speed = 7f;
        }

        if (Input.GetKey("s"))
        {
            speed = 4f;
        }

        
    }

    IEnumerator Controls()
    {
        while (true) 
        {
            if (Input.GetKey("d"))
                {
                    Player.transform.eulerAngles = new Vector3 (Player.transform.eulerAngles.x, Player.transform.eulerAngles.y + 5, Player.transform.eulerAngles.z);
                    
                    Debug.Log ("Turning Right");
                    yield return new WaitForSeconds(0.01f);
                }
                else if (Input.GetKey("a"))
                {
                    Player.transform.eulerAngles = new Vector3 (Player.transform.eulerAngles.x, Player.transform.eulerAngles.y - 5, Player.transform.eulerAngles.z);
                    
                    Debug.Log ("Turning Left");
                    yield return new WaitForSeconds(0.01f);
                }
                else
                {
                    Debug.Log ("Not Turning");
                    yield return new WaitForSeconds(0.001f);
                }

                if (Input.GetKeyDown("space"))
                    {
                        rb.AddForce(Vector3.up * jumpHeight);
                        
                        Debug.Log ("Jump");
                        yield return new WaitForSeconds(1f);
                    }
        }
    }
}
