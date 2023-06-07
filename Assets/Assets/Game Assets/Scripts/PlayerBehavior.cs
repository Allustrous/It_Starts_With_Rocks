using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public GameObject Pause;
    public GameObject Stamina1;
    public GameObject Stamina2;
    public GameObject Stamina3;
    public GameObject Stamina4;
    public GameObject Stamina5;
    public GameObject Stamina6;
    public GameObject Stamina7;
    public GameObject Stamina8;
    public GameObject Stamina9;

    public float speed = 10f;
    float jumpHeight = 900;
    Rigidbody rb;
    public GameObject Player;
    public GameObject Rock;
    public GameObject Fiber;
    public GameObject Wood;
    public float stamina = 9f;

    // Update is called once per frame

    void Start () {
        StartCoroutine(Controls());
        StartCoroutine(Stamina());
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        
        float vertical =Input.GetAxis("Vertical");
       

        
        float horizontal =Input.GetAxis("Horizontal");

        
        Vector3 motion12Vector = new Vector3(0, 0, vertical);
        

        transform.Translate(motion12Vector *speed *Time.deltaTime);

        if (Input.GetKeyDown("escape"))
        {
            Pause.SetActive(true);
        }
        
        if (Input.GetKeyUp("s"))
        {
            speed = 10f;
        }

        if (Input.GetKeyDown("s"))
        {
            speed = 7f;
        }

        if (stamina == 8)
        {
            Stamina9.SetActive(false);
            Stamina8.SetActive(true);
        }
        else if(stamina == 7)
        {
            Stamina8.SetActive(false);
            Stamina7.SetActive(true);
        }
        else if(stamina == 6)
        {
            Stamina7.SetActive(false);
            Stamina6.SetActive(true);
        }
        else if(stamina == 5)
        {
            Stamina6.SetActive(false);
            Stamina5.SetActive(true);
        }
        else if(stamina == 4)
        {
            Stamina5.SetActive(false);
            Stamina4.SetActive(true);
        }
        else if(stamina == 3)
        {
            Stamina4.SetActive(false);
            Stamina3.SetActive(true);
        }
        else if(stamina == 2)
        {
            Stamina3.SetActive(false);
            Stamina2.SetActive(true);
        }
        else if(stamina == 1)
        {
            Stamina2.SetActive(false);
            Stamina1.SetActive(true);
        }
        else if(stamina == 0)
        {
            Stamina1.SetActive(false);
        }
        else if(stamina == 9)
        {
            Stamina9.SetActive(true);
        }
    }



        

    IEnumerator Controls()
    {
        while (true) 
        {
            if (Input.GetKey("d"))
                {
                    Player.transform.eulerAngles = new Vector3 (Player.transform.eulerAngles.x, Player.transform.eulerAngles.y + 5, Player.transform.eulerAngles.z);
                    
                    
                    yield return new WaitForSeconds(0.01f);
                }
                else if (Input.GetKey("a"))
                {
                    Player.transform.eulerAngles = new Vector3 (Player.transform.eulerAngles.x, Player.transform.eulerAngles.y - 5, Player.transform.eulerAngles.z);
                    
                    
                    yield return new WaitForSeconds(0.01f);
                }
                else
                {
                    
                    yield return new WaitForSeconds(0.001f);
                }


                if (Input.GetKeyDown("space"))
                {
                    rb.AddForce(Vector3.up * jumpHeight);

                    yield return new WaitForSeconds(1f);
                }
        }
    }

    IEnumerator Stamina()
    {
                while(true)
                {
                    if (stamina > 1)
                    {
                        if (Input.GetKeyDown("left shift"))
                        {
                            speed = 18f;
                            StopCoroutine("Recover");
                            StartCoroutine("Dash");
                            yield return new WaitForSeconds(0.001f);
                        }
                        if (Input.GetKeyUp("left shift"))
                        {
                            speed = 10f;
                            StopCoroutine("Dash");
                            StartCoroutine("Recover");
                            yield return new WaitForSeconds(0.001f);
                        }
                    }
                    else
                    {
                        speed = 10f;
                        StopCoroutine("Dash");
                        StartCoroutine("Recover");
                        yield return new WaitForSeconds(0.001f);
                    }
                    yield return null;
                }
    }


    IEnumerator Dash()
    {
        while(true) 
        {
            stamina--;
            
            yield return new WaitForSeconds(3f);
        }
    }
    
    IEnumerator Recover()
    {
        while(true) 
        {
            if (stamina < 9)
            {
                stamina++;
                
                yield return new WaitForSeconds(2f);
            }
            else if (stamina == 9)
            {
                StopCoroutine("Recover");
            }
            yield return null;
        }
    }

}
