using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StoneGather : MonoBehaviour
{
    public ResourceCounter resourcecounter;
    public float gatheringCounter = 0;
    public float TimeLeft = 5;
    public float TimerOn = 0;


    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gatheringCounter++;
            Debug.Log("StonePicked");
        }
    }

    void Start()
    {
    
    }

    void Update()
    {
        if(TimerOn == 1)
        {
            Debug.Log(TimeLeft);
            if(TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
                Debug.Log(TimeLeft);
            }
            else{
                Debug.Log(TimeLeft);
                TimeLeft = 0;
                TimerOn--;
                gameObject.SetActive(true);
            }
        }
        if (gatheringCounter == 5)
                {
                    Debug.Log("StoneGathered");
                    gameObject.SetActive(false);
                    TimerOn += 1;
                    resourcecounter.gatheredStone += 5;
                }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);
    }


}
