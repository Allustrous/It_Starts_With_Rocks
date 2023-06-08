using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : MonoBehaviour
{
    public float axeTier = 1;
    public float pickTier = 1;
    public float sickleTier = 1;
    public float spearTier = 1;
    public float clubTier = 1;

    public GameObject axeSprite1;
    public GameObject axeSprite2;
    public GameObject axeSprite3;
    public GameObject pickSprite1;
    public GameObject pickSprite2;
    public GameObject pickSprite3;
    public GameObject sickleSprite1;
    public GameObject sickleSprite2;
    public GameObject sickleSprite3;
    public GameObject spearSprite1;
    public GameObject spearSprite2;
    public GameObject spearSprite3;
    public GameObject clubSprite1;
    public GameObject clubSprite2;
    public GameObject clubSprite3;

    public GameObject axe1;
    public GameObject axe2;
    public GameObject axe3;
    public GameObject pick1;
    public GameObject pick2;
    public GameObject pick3;
    public GameObject sickle1;
    public GameObject sickle2;
    public GameObject sickle3;
    public GameObject spear1;
    public GameObject spear2;
    public GameObject spear3;
    public GameObject club1;
    public GameObject club2;
    public GameObject club3;

    public GameObject PlayerHand;
    public GameObject Player;

    float axe1spawned = 0;
    float axe2spawned = 0;
    float axe3spawned = 0;
    float pick1spawned = 0;
    float pick2spawned = 0;
    float pick3spawned = 0;
    float sickle1spawned = 0;
    float sickle2spawned = 0;
    float sickle3spawned = 0;
    float spear1spawned = 0;
    float spear2spawned = 0;
    float spear3spawned = 0;
    float club1spawned = 0;
    float club2spawned = 0;
    float club3spawned = 0;

    GameObject spawnedAxe1;
    GameObject spawnedAxe2;
    GameObject spawnedAxe3;
    GameObject spawnedPick1;
    GameObject spawnedPick2;
    GameObject spawnedPick3;
    GameObject spawnedSickle1;
    GameObject spawnedSickle2;
    GameObject spawnedSickle3;
    GameObject spawnedSpear1;
    GameObject spawnedSpear2;
    GameObject spawnedSpear3;
    GameObject spawnedClub1;
    GameObject spawnedClub2;
    GameObject spawnedClub3;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 playerPOS = PlayerHand.transform.position;
        float playerROT = Player.transform.rotation.y;



        // Axe
        if (axeTier == 1)
        {
            axeSprite1.SetActive(true);
            axeSprite2.SetActive(false);
            axeSprite3.SetActive(false);
            if(axe1spawned == 0)
            {
                if(Input.GetKeyDown("1"))
                {
                    spawnedAxe1 = Instantiate(axe1, playerPOS, Quaternion.identity);
                    spawnedAxe1.transform.parent = transform;
                    spawnedAxe1.transform.localRotation = Quaternion.Euler(0,playerROT,0);
                    axe1spawned = 1;
                    Destroy(spawnedAxe2);
                    Destroy(spawnedAxe3);
                    Destroy(spawnedPick1);
                    Destroy(spawnedPick2);
                    Destroy(spawnedPick3);
                    Destroy(spawnedSickle1);
                    Destroy(spawnedSickle2);
                    Destroy(spawnedSickle3);
                    Destroy(spawnedSpear1);
                    Destroy(spawnedSpear2);
                    Destroy(spawnedSpear3);
                    Destroy(spawnedClub1);
                    Destroy(spawnedClub2);
                    Destroy(spawnedClub3);
                    axe2spawned = 0;
                    axe3spawned = 0;
                    pick1spawned = 0;
                    pick2spawned = 0;
                    pick3spawned = 0;
                    sickle1spawned = 0;
                    sickle2spawned = 0;
                    sickle3spawned = 0;
                    spear1spawned = 0;
                    spear2spawned = 0;
                    spear3spawned = 0;
                    club1spawned = 0;
                    club2spawned = 0;
                    club3spawned = 0;


                }
            }
            else if (axe1spawned == 1)
            {
                if(Input.GetKeyDown("1"))
                {
                    axe1spawned = 0;
                    Destroy(spawnedAxe1);
                }
            }

        }
        else if (axeTier == 2)
        {
            axeSprite1.SetActive(false);
            axeSprite2.SetActive(true);
            axeSprite3.SetActive(false);
            if(axe2spawned == 0)
            {
                if(Input.GetKeyDown("1"))
                {
                    spawnedAxe2 = Instantiate(axe2, playerPOS, Quaternion.identity);
                    spawnedAxe2.transform.parent = transform;
                    spawnedAxe2.transform.localRotation = Quaternion.Euler(0,playerROT,0);
                    axe2spawned = 1;
                    Destroy(spawnedAxe1);
                    Destroy(spawnedAxe3);
                    Destroy(spawnedPick1);
                    Destroy(spawnedPick2);
                    Destroy(spawnedPick3);
                    Destroy(spawnedSickle1);
                    Destroy(spawnedSickle2);
                    Destroy(spawnedSickle3);
                    Destroy(spawnedSpear1);
                    Destroy(spawnedSpear2);
                    Destroy(spawnedSpear3);
                    Destroy(spawnedClub1);
                    Destroy(spawnedClub2);
                    Destroy(spawnedClub3);

                    axe1spawned = 0;
                    axe3spawned = 0;
                    pick1spawned = 0;
                    pick2spawned = 0;
                    pick3spawned = 0;
                    sickle1spawned = 0;
                    sickle2spawned = 0;
                    sickle3spawned = 0;
                    spear1spawned = 0;
                    spear2spawned = 0;
                    spear3spawned = 0;
                    club1spawned = 0;
                    club2spawned = 0;
                    club3spawned = 0;
                }
            }
            else if (axe2spawned == 1)
            {
                if(Input.GetKeyDown("1"))
                {
                    axe2spawned = 0;
                    Destroy(spawnedAxe2);
                }
            }

        }
        else if (axeTier == 3)
        {
            axeSprite1.SetActive(false);
            axeSprite2.SetActive(false);
            axeSprite3.SetActive(true);
            if(axe3spawned == 0)
            {
                if(Input.GetKeyDown("1"))
                {
                    spawnedAxe3 = Instantiate(axe3, playerPOS, Quaternion.identity);
                    spawnedAxe3.transform.parent = transform;
                    spawnedAxe3.transform.localRotation = Quaternion.Euler(0,playerROT,0);
                    axe3spawned = 1;
                    Destroy(spawnedAxe1);
                    Destroy(spawnedAxe2);
                    Destroy(spawnedPick1);
                    Destroy(spawnedPick2);
                    Destroy(spawnedPick3);
                    Destroy(spawnedSickle1);
                    Destroy(spawnedSickle2);
                    Destroy(spawnedSickle3);
                    Destroy(spawnedSpear1);
                    Destroy(spawnedSpear2);
                    Destroy(spawnedSpear3);
                    Destroy(spawnedClub1);
                    Destroy(spawnedClub2);
                    Destroy(spawnedClub3);

                    axe1spawned = 0;
                    axe2spawned = 0;
                    pick1spawned = 0;
                    pick2spawned = 0;
                    pick3spawned = 0;
                    sickle1spawned = 0;
                    sickle2spawned = 0;
                    sickle3spawned = 0;
                    spear1spawned = 0;
                    spear2spawned = 0;
                    spear3spawned = 0;
                    club1spawned = 0;
                    club2spawned = 0;
                    club3spawned = 0;
                }
            }
            else if (axe3spawned == 1)
            {
                if(Input.GetKeyDown("1"))
                {
                    axe3spawned = 0;
                    Destroy(spawnedAxe3);
                }
            }

        }

        // Pick
        if (pickTier == 1)
        {
            pickSprite1.SetActive(true);
            pickSprite2.SetActive(false);
            pickSprite3.SetActive(false);
            if(pick1spawned == 0)
            {
                if(Input.GetKeyDown("2"))
                {
                    spawnedPick1 = Instantiate(pick1, playerPOS, Quaternion.identity);
                    spawnedPick1.transform.parent = transform;
                    spawnedPick1.transform.localRotation = Quaternion.Euler(0,playerROT,0);
                    pick1spawned = 1;
                    Destroy(spawnedAxe1);
                    Destroy(spawnedAxe2);
                    Destroy(spawnedAxe3);
                    Destroy(spawnedPick2);
                    Destroy(spawnedPick3);
                    Destroy(spawnedSickle1);
                    Destroy(spawnedSickle2);
                    Destroy(spawnedSickle3);
                    Destroy(spawnedSpear1);
                    Destroy(spawnedSpear2);
                    Destroy(spawnedSpear3);
                    Destroy(spawnedClub1);
                    Destroy(spawnedClub2);
                    Destroy(spawnedClub3);

                    axe1spawned = 0;
                    axe2spawned = 0;
                    axe3spawned = 0;
                    pick2spawned = 0;
                    pick3spawned = 0;
                    sickle1spawned = 0;
                    sickle2spawned = 0;
                    sickle3spawned = 0;
                    spear1spawned = 0;
                    spear2spawned = 0;
                    spear3spawned = 0;
                    club1spawned = 0;
                    club2spawned = 0;
                    club3spawned = 0;
                }
            }
            else if (pick1spawned == 1)
            {
                if(Input.GetKeyDown("2"))
                {
                    pick1spawned = 0;
                    Destroy(spawnedPick1);
                }
            }

        }
        else if (pickTier == 2)
        {
            pickSprite1.SetActive(false);
            pickSprite2.SetActive(true);
            pickSprite3.SetActive(false);
            if(pick2spawned == 0)
            {
                if(Input.GetKeyDown("2"))
                {
                    spawnedPick2 = Instantiate(pick2, playerPOS, Quaternion.identity);
                    spawnedPick2.transform.parent = transform;
                    spawnedPick2.transform.localRotation = Quaternion.Euler(0,playerROT,0);
                    pick2spawned = 1;
                    Destroy(spawnedAxe1);
                    Destroy(spawnedAxe2);
                    Destroy(spawnedAxe3);
                    Destroy(spawnedPick1);
                    Destroy(spawnedPick3);
                    Destroy(spawnedSickle1);
                    Destroy(spawnedSickle2);
                    Destroy(spawnedSickle3);
                    Destroy(spawnedSpear1);
                    Destroy(spawnedSpear2);
                    Destroy(spawnedSpear3);
                    Destroy(spawnedClub1);
                    Destroy(spawnedClub2);
                    Destroy(spawnedClub3);

                    axe1spawned = 0;
                    axe2spawned = 0;
                    axe3spawned = 0;
                    pick1spawned = 0;
                    pick3spawned = 0;
                    sickle1spawned = 0;
                    sickle2spawned = 0;
                    sickle3spawned = 0;
                    spear1spawned = 0;
                    spear2spawned = 0;
                    spear3spawned = 0;
                    club1spawned = 0;
                    club2spawned = 0;
                    club3spawned = 0;
                }
            }
            else if (pick2spawned == 1)
            {
                if(Input.GetKeyDown("2"))
                {
                    pick2spawned = 0;
                    Destroy(spawnedPick2);
                }
            }

        }
        else if (pickTier == 3)
        {
            pickSprite1.SetActive(false);
            pickSprite2.SetActive(false);
            pickSprite3.SetActive(true);
            if(pick3spawned == 0)
            {
                if(Input.GetKeyDown("2"))
                {
                    spawnedPick3 = Instantiate(pick3, playerPOS, Quaternion.identity);
                    spawnedPick3.transform.parent = transform;
                    spawnedPick3.transform.localRotation = Quaternion.Euler(0,playerROT,0);
                    pick3spawned = 1;
                    Destroy(spawnedAxe1);
                    Destroy(spawnedAxe2);
                    Destroy(spawnedAxe3);
                    Destroy(spawnedPick1);
                    Destroy(spawnedPick2);
                    Destroy(spawnedSickle1);
                    Destroy(spawnedSickle2);
                    Destroy(spawnedSickle3);
                    Destroy(spawnedSpear1);
                    Destroy(spawnedSpear2);
                    Destroy(spawnedSpear3);
                    Destroy(spawnedClub1);
                    Destroy(spawnedClub2);
                    Destroy(spawnedClub3);

                    axe1spawned = 0;
                    axe2spawned = 0;
                    axe3spawned = 0;
                    pick1spawned = 0;
                    pick2spawned = 0;
                    sickle1spawned = 0;
                    sickle2spawned = 0;
                    sickle3spawned = 0;
                    spear1spawned = 0;
                    spear2spawned = 0;
                    spear3spawned = 0;
                    club1spawned = 0;
                    club2spawned = 0;
                    club3spawned = 0;
                }
            }
            else if (pick3spawned == 1)
            {
                if(Input.GetKeyDown("2"))
                {
                    pick3spawned = 0;
                    Destroy(spawnedPick3);
                }
            }

        }

        // Sickle
        if (sickleTier == 1)
        {
            sickleSprite1.SetActive(true);
            sickleSprite2.SetActive(false);
            sickleSprite3.SetActive(false);
            if(sickle1spawned == 0)
            {
                if(Input.GetKeyDown("3"))
                {
                    spawnedSickle1 = Instantiate(sickle1, playerPOS, Quaternion.identity);
                    spawnedSickle1.transform.parent = transform;
                    spawnedSickle1.transform.localRotation = Quaternion.Euler(0,playerROT,0);
                    sickle1spawned = 1;
                    Destroy(spawnedAxe1);
                    Destroy(spawnedAxe2);
                    Destroy(spawnedAxe3);
                    Destroy(spawnedPick1);
                    Destroy(spawnedPick2);
                    Destroy(spawnedPick3);
                    Destroy(spawnedSickle2);
                    Destroy(spawnedSickle3);
                    Destroy(spawnedSpear1);
                    Destroy(spawnedSpear2);
                    Destroy(spawnedSpear3);
                    Destroy(spawnedClub1);
                    Destroy(spawnedClub2);
                    Destroy(spawnedClub3);

                    axe1spawned = 0;
                    axe2spawned = 0;
                    axe3spawned = 0;
                    pick1spawned = 0;
                    pick2spawned = 0;
                    pick3spawned = 0;
                    sickle2spawned = 0;
                    sickle3spawned = 0;
                    spear1spawned = 0;
                    spear2spawned = 0;
                    spear3spawned = 0;
                    club1spawned = 0;
                    club2spawned = 0;
                    club3spawned = 0;

                }
            }
            else if (sickle1spawned == 1)
            {
                if(Input.GetKeyDown("3"))
                {
                    sickle1spawned = 0;
                    Destroy(spawnedSickle1);
                }
            }

        }
        else if (sickleTier == 2)
        {
            sickleSprite1.SetActive(false);
            sickleSprite2.SetActive(true);
            sickleSprite3.SetActive(false);
            if(sickle2spawned == 0)
            {
                if(Input.GetKeyDown("3"))
                {
                    spawnedSickle2 = Instantiate(sickle2, playerPOS, Quaternion.identity);
                    spawnedSickle2.transform.parent = transform;
                    spawnedSickle2.transform.localRotation = Quaternion.Euler(0,playerROT,0);
                    sickle2spawned = 1;
                    Destroy(spawnedAxe1);
                    Destroy(spawnedAxe2);
                    Destroy(spawnedAxe3);
                    Destroy(spawnedPick1);
                    Destroy(spawnedPick2);
                    Destroy(spawnedPick3);
                    Destroy(spawnedSickle1);
                    Destroy(spawnedSickle3);
                    Destroy(spawnedSpear1);
                    Destroy(spawnedSpear2);
                    Destroy(spawnedSpear3);
                    Destroy(spawnedClub1);
                    Destroy(spawnedClub2);
                    Destroy(spawnedClub3);

                    axe1spawned = 0;
                    axe2spawned = 0;
                    axe3spawned = 0;
                    pick1spawned = 0;
                    pick2spawned = 0;
                    pick3spawned = 0;
                    sickle1spawned = 0;
                    sickle3spawned = 0;
                    spear1spawned = 0;
                    spear2spawned = 0;
                    spear3spawned = 0;
                    club1spawned = 0;
                    club2spawned = 0;
                    club3spawned = 0;
                }
            }
            else if (sickle2spawned == 1)
            {
                if(Input.GetKeyDown("3"))
                {
                    sickle2spawned = 0;
                    Destroy(spawnedSickle2);
                }
            }

        }
        else if (sickleTier == 3)
        {
            sickleSprite1.SetActive(false);
            sickleSprite2.SetActive(false);
            sickleSprite3.SetActive(true);
            if(sickle3spawned == 0)
            {
                if(Input.GetKeyDown("3"))
                {
                    spawnedSickle3 = Instantiate(sickle3, playerPOS, Quaternion.identity);
                    spawnedSickle3.transform.parent = transform;
                    spawnedSickle3.transform.localRotation = Quaternion.Euler(0,playerROT,0);
                    sickle3spawned = 1;
                    Destroy(spawnedAxe1);
                    Destroy(spawnedAxe2);
                    Destroy(spawnedAxe3);
                    Destroy(spawnedPick1);
                    Destroy(spawnedPick2);
                    Destroy(spawnedPick3);
                    Destroy(spawnedSickle1);
                    Destroy(spawnedSickle2);
                    Destroy(spawnedSpear1);
                    Destroy(spawnedSpear2);
                    Destroy(spawnedSpear3);
                    Destroy(spawnedClub1);
                    Destroy(spawnedClub2);
                    Destroy(spawnedClub3);
                    
                    axe1spawned = 0;
                    axe2spawned = 0;
                    axe3spawned = 0;
                    pick1spawned = 0;
                    pick2spawned = 0;
                    pick3spawned = 0;
                    sickle1spawned = 0;
                    sickle2spawned = 0;
                    spear1spawned = 0;
                    spear2spawned = 0;
                    spear3spawned = 0;
                    club1spawned = 0;
                    club2spawned = 0;
                    club3spawned = 0;
                }
            }
            else if (sickle3spawned == 1)
            {
                if(Input.GetKeyDown("3"))
                {
                    sickle3spawned = 0;
                    Destroy(spawnedSickle3);
                }
            }

        }


        // Spear
        if (spearTier == 1)
        {
            spearSprite1.SetActive(true);
            spearSprite2.SetActive(false);
            spearSprite3.SetActive(false);
            if(spear1spawned == 0)
            {
                if(Input.GetKeyDown("4"))
                {
                    spawnedSpear1 = Instantiate(spear1, playerPOS, Quaternion.identity);
                    spawnedSpear1.transform.parent = transform;
                    spawnedSpear1.transform.localRotation = Quaternion.Euler(0,playerROT,0);
                    spear1spawned = 1;
                    Destroy(spawnedAxe1);
                    Destroy(spawnedAxe2);
                    Destroy(spawnedAxe3);
                    Destroy(spawnedPick1);
                    Destroy(spawnedPick2);
                    Destroy(spawnedPick3);
                    Destroy(spawnedSickle1);
                    Destroy(spawnedSickle2);
                    Destroy(spawnedSickle3);
                    Destroy(spawnedSpear2);
                    Destroy(spawnedSpear3);
                    Destroy(spawnedClub1);
                    Destroy(spawnedClub2);
                    Destroy(spawnedClub3);

                    axe1spawned = 0;
                    axe2spawned = 0;
                    axe3spawned = 0;
                    pick1spawned = 0;
                    pick2spawned = 0;
                    pick3spawned = 0;
                    sickle1spawned = 0;
                    sickle2spawned = 0;
                    sickle3spawned = 0;
                    spear2spawned = 0;
                    spear3spawned = 0;
                    club1spawned = 0;
                    club2spawned = 0;
                    club3spawned = 0;
                }
            }
            else if (spear1spawned == 1)
            {
                if(Input.GetKeyDown("4"))
                {
                    spear1spawned = 0;
                    Destroy(spawnedSpear1);
                }
            }

        }
        else if (spearTier == 2)
        {
            spearSprite1.SetActive(false);
            spearSprite2.SetActive(true);
            spearSprite3.SetActive(false);
            if(spear2spawned == 0)
            {
                if(Input.GetKeyDown("4"))
                {
                    spawnedSpear2 = Instantiate(spear2, playerPOS, Quaternion.identity);
                    spawnedSpear2.transform.parent = transform;
                    spawnedSpear2.transform.localRotation = Quaternion.Euler(0,playerROT,0);
                    spear2spawned = 1;
                    Destroy(spawnedAxe1);
                    Destroy(spawnedAxe2);
                    Destroy(spawnedAxe3);
                    Destroy(spawnedPick1);
                    Destroy(spawnedPick2);
                    Destroy(spawnedPick3);
                    Destroy(spawnedSickle1);
                    Destroy(spawnedSickle2);
                    Destroy(spawnedSickle3);
                    Destroy(spawnedSpear1);
                    Destroy(spawnedSpear3);
                    Destroy(spawnedClub1);
                    Destroy(spawnedClub2);
                    Destroy(spawnedClub3);

                    axe1spawned = 0;
                    axe2spawned = 0;
                    axe3spawned = 0;
                    pick1spawned = 0;
                    pick2spawned = 0;
                    pick3spawned = 0;
                    sickle1spawned = 0;
                    sickle2spawned = 0;
                    sickle3spawned = 0;
                    spear1spawned = 0;
                    spear3spawned = 0;
                    club1spawned = 0;
                    club2spawned = 0;
                    club3spawned = 0;
                }
            }
            else if (spear2spawned == 1)
            {
                if(Input.GetKeyDown("4"))
                {
                    spear2spawned = 0;
                    Destroy(spawnedSpear2);
                }
            }

        }
        else if (spearTier == 3)
        {
            spearSprite1.SetActive(false);
            spearSprite2.SetActive(false);
            spearSprite3.SetActive(true);
            if(spear3spawned == 0)
            {
                if(Input.GetKeyDown("4"))
                {
                    spawnedSpear3 = Instantiate(spear3, playerPOS, Quaternion.identity);
                    spawnedSpear3.transform.parent = transform;
                    spawnedSpear3.transform.localRotation = Quaternion.Euler(0,playerROT,0);
                    spear3spawned = 1;
                    Destroy(spawnedAxe1);
                    Destroy(spawnedAxe2);
                    Destroy(spawnedAxe3);
                    Destroy(spawnedPick1);
                    Destroy(spawnedPick2);
                    Destroy(spawnedPick3);
                    Destroy(spawnedSickle1);
                    Destroy(spawnedSickle2);
                    Destroy(spawnedSickle3);
                    Destroy(spawnedSpear1);
                    Destroy(spawnedSpear2);
                    Destroy(spawnedClub1);
                    Destroy(spawnedClub2);
                    Destroy(spawnedClub3);

                    axe1spawned = 0;
                    axe2spawned = 0;
                    axe3spawned = 0;
                    pick1spawned = 0;
                    pick2spawned = 0;
                    pick3spawned = 0;
                    sickle1spawned = 0;
                    sickle2spawned = 0;
                    sickle3spawned = 0;
                    spear1spawned = 0;
                    spear2spawned = 0;
                    club1spawned = 0;
                    club2spawned = 0;
                    club3spawned = 0;

                }
            }
            else if (spear3spawned == 1)
            {
                if(Input.GetKeyDown("4"))
                {
                    spear3spawned = 0;
                    Destroy(spawnedSpear3);
                }
            }

        }

        // Club
        if (clubTier == 1)
        {
            clubSprite1.SetActive(true);
            clubSprite2.SetActive(false);
            clubSprite3.SetActive(false);
            if(club1spawned == 0)
            {
                if(Input.GetKeyDown("5"))
                {
                    spawnedClub1 = Instantiate(club1, playerPOS, Quaternion.identity);
                    spawnedClub1.transform.parent = transform;
                    spawnedClub1.transform.localRotation = Quaternion.Euler(0,playerROT,0);
                    club1spawned = 1;
                    Destroy(spawnedAxe1);
                    Destroy(spawnedAxe2);
                    Destroy(spawnedAxe3);
                    Destroy(spawnedPick1);
                    Destroy(spawnedPick2);
                    Destroy(spawnedPick3);
                    Destroy(spawnedSickle1);
                    Destroy(spawnedSickle2);
                    Destroy(spawnedSickle3);
                    Destroy(spawnedSpear1);
                    Destroy(spawnedSpear2);
                    Destroy(spawnedSpear3);
                    Destroy(spawnedClub2);
                    Destroy(spawnedClub3);

                    axe1spawned = 0;
                    axe2spawned = 0;
                    axe3spawned = 0;
                    pick1spawned = 0;
                    pick2spawned = 0;
                    pick3spawned = 0;
                    sickle1spawned = 0;
                    sickle2spawned = 0;
                    sickle3spawned = 0;
                    spear1spawned = 0;
                    spear2spawned = 0;
                    spear3spawned = 0;
                    club2spawned = 0;
                    club3spawned = 0;
                }
            }
            else if (club1spawned == 1)
            {
                if(Input.GetKeyDown("5"))
                {
                    club1spawned = 0;
                    Destroy(spawnedClub1);
                }
            }

        }
        else if (clubTier == 2)
        {
            clubSprite1.SetActive(false);
            clubSprite2.SetActive(true);
            clubSprite3.SetActive(false);
            if(club2spawned == 0)
            {
                if(Input.GetKeyDown("5"))
                {
                    spawnedClub2 = Instantiate(club2, playerPOS, Quaternion.identity);
                    spawnedClub2.transform.parent = transform;
                    spawnedClub2.transform.localRotation = Quaternion.Euler(0,playerROT,0);
                    club2spawned = 1;
                    Destroy(spawnedAxe1);
                    Destroy(spawnedAxe2);
                    Destroy(spawnedAxe3);
                    Destroy(spawnedPick1);
                    Destroy(spawnedPick2);
                    Destroy(spawnedPick3);
                    Destroy(spawnedSickle1);
                    Destroy(spawnedSickle2);
                    Destroy(spawnedSickle3);
                    Destroy(spawnedSpear1);
                    Destroy(spawnedSpear2);
                    Destroy(spawnedSpear3);
                    Destroy(spawnedClub1);
                    Destroy(spawnedClub3);

                    axe1spawned = 0;
                    axe2spawned = 0;
                    axe3spawned = 0;
                    pick1spawned = 0;
                    pick2spawned = 0;
                    pick3spawned = 0;
                    sickle1spawned = 0;
                    sickle2spawned = 0;
                    sickle3spawned = 0;
                    spear1spawned = 0;
                    spear2spawned = 0;
                    spear3spawned = 0;
                    club1spawned = 0;
                    club3spawned = 0;
                }
            }
            else if (club2spawned == 1)
            {
                if(Input.GetKeyDown("5"))
                {
                    club2spawned = 0;
                    Destroy(spawnedClub2);
                }
            }

        }
        else if (clubTier == 3)
        {
            clubSprite1.SetActive(false);
            clubSprite2.SetActive(false);
            clubSprite3.SetActive(true);
            if(club3spawned == 0)
            {
                if(Input.GetKeyDown("5"))
                {
                    spawnedClub3 = Instantiate(club3, playerPOS, Quaternion.identity);
                    spawnedClub3.transform.parent = transform;
                    spawnedClub3.transform.localRotation = Quaternion.Euler(0,playerROT,0);
                    club3spawned = 1;
                    Destroy(spawnedAxe1);
                    Destroy(spawnedAxe2);
                    Destroy(spawnedAxe3);
                    Destroy(spawnedPick1);
                    Destroy(spawnedPick2);
                    Destroy(spawnedPick3);
                    Destroy(spawnedSickle1);
                    Destroy(spawnedSickle2);
                    Destroy(spawnedSickle3);
                    Destroy(spawnedSpear1);
                    Destroy(spawnedSpear2);
                    Destroy(spawnedSpear3);
                    Destroy(spawnedClub1);
                    Destroy(spawnedClub2);

                    axe1spawned = 0;
                    axe2spawned = 0;
                    axe3spawned = 0;
                    pick1spawned = 0;
                    pick2spawned = 0;
                    pick3spawned = 0;
                    sickle1spawned = 0;
                    sickle2spawned = 0;
                    sickle3spawned = 0;
                    spear1spawned = 0;
                    spear2spawned = 0;
                    spear3spawned = 0;
                    club1spawned = 0;
                    club2spawned = 0;

                }
            }
            else if (club3spawned == 1)
            {
                if(Input.GetKeyDown("5"))
                {
                    club3spawned = 0;
                    Destroy(spawnedClub3);
                }
            }

        }


    }
}
