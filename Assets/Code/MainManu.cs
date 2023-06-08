using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainManu : MonoBehaviour
{
    public Equipment equipment;
    public CampsiteDeposit campsitedeposit;
    public GameObject Upgrade1a;
    public GameObject Upgrade2a;
    public GameObject Upgrade3a;
    public GameObject Upgrade4a;
    public GameObject Upgrade5a;
    public GameObject Upgrade1b;
    public GameObject Upgrade2b;
    public GameObject Upgrade3b;
    public GameObject Upgrade4b;
    public GameObject Upgrade5b;

    public GameObject Desc1a;
    public GameObject Desc2a;
    public GameObject Desc3a;
    public GameObject Desc4a;
    public GameObject Desc5a;
    public GameObject Desc1b;
    public GameObject Desc2b;
    public GameObject Desc3b;
    public GameObject Desc4b;
    public GameObject Desc5b;

// This loads a new scene
public void LoadScene(string sceneName) //so we can use it for multiple scenes
{
    SceneManager.LoadScene(sceneName);
}

public void Quit()
{
    Application.Quit();
    Debug.Log("Application has quit");
}

public void SwapPannel(GameObject selected)
{
    GameObject[] canvasList = GameObject.FindGameObjectsWithTag("UiCanvas");
    foreach(GameObject canvas in canvasList)
    {
        canvas.SetActive(false);
    }

    selected.SetActive(true);
}

public void Option1a()
{
    Desc1a.SetActive(true);
    Desc2a.SetActive(false);
    Desc3a.SetActive(false);
    Desc4a.SetActive(false);
    Desc5a.SetActive(false);
    Desc1b.SetActive(false);
    Desc2b.SetActive(false);
    Desc3b.SetActive(false);
    Desc4b.SetActive(false);
    Desc5b.SetActive(false);
}

public void Option2a()
{
    Desc1a.SetActive(false);
    Desc2a.SetActive(true);
    Desc3a.SetActive(false);
    Desc4a.SetActive(false);
    Desc5a.SetActive(false);
    Desc1b.SetActive(false);
    Desc2b.SetActive(false);
    Desc3b.SetActive(false);
    Desc4b.SetActive(false);
    Desc5b.SetActive(false);
}

public void Option3a()
{
    Desc1a.SetActive(false);
    Desc2a.SetActive(false);
    Desc3a.SetActive(true);
    Desc4a.SetActive(false);
    Desc5a.SetActive(false);
    Desc1b.SetActive(false);
    Desc2b.SetActive(false);
    Desc3b.SetActive(false);
    Desc4b.SetActive(false);
    Desc5b.SetActive(false);
}

public void Option4a()
{
    Desc1a.SetActive(false);
    Desc2a.SetActive(false);
    Desc3a.SetActive(false);
    Desc4a.SetActive(true);
    Desc5a.SetActive(false);
    Desc1b.SetActive(false);
    Desc2b.SetActive(false);
    Desc3b.SetActive(false);
    Desc4b.SetActive(false);
    Desc5b.SetActive(false);
}

public void Option5a()
{
    Desc1a.SetActive(false);
    Desc2a.SetActive(false);
    Desc3a.SetActive(false);
    Desc4a.SetActive(false);
    Desc5a.SetActive(true);
    Desc1b.SetActive(false);
    Desc2b.SetActive(false);
    Desc3b.SetActive(false);
    Desc4b.SetActive(false);
    Desc5b.SetActive(false);
}

public void Option1b()
{
    Desc1a.SetActive(false);
    Desc2a.SetActive(false);
    Desc3a.SetActive(false);
    Desc4a.SetActive(false);
    Desc5a.SetActive(false);
    Desc1b.SetActive(true);
    Desc2b.SetActive(false);
    Desc3b.SetActive(false);
    Desc4b.SetActive(false);
    Desc5b.SetActive(false);
}

public void Option2b()
{
    Desc1a.SetActive(false);
    Desc2a.SetActive(false);
    Desc3a.SetActive(false);
    Desc4a.SetActive(false);
    Desc5a.SetActive(false);
    Desc1b.SetActive(false);
    Desc2b.SetActive(true);
    Desc3b.SetActive(false);
    Desc4b.SetActive(false);
    Desc5b.SetActive(false);
}

public void Option3b()
{
    Desc1a.SetActive(false);
    Desc2a.SetActive(false);
    Desc3a.SetActive(false);
    Desc4a.SetActive(false);
    Desc5a.SetActive(false);
    Desc1b.SetActive(false);
    Desc2b.SetActive(false);
    Desc3b.SetActive(true);
    Desc4b.SetActive(false);
    Desc5b.SetActive(false);
}

public void Option4b()
{
    Desc1a.SetActive(false);
    Desc2a.SetActive(false);
    Desc3a.SetActive(false);
    Desc4a.SetActive(false);
    Desc5a.SetActive(false);
    Desc1b.SetActive(false);
    Desc2b.SetActive(false);
    Desc3b.SetActive(false);
    Desc4b.SetActive(true);
    Desc5b.SetActive(false);
}

public void Option5b()
{
    Desc1a.SetActive(false);
    Desc2a.SetActive(false);
    Desc3a.SetActive(false);
    Desc4a.SetActive(false);
    Desc5a.SetActive(false);
    Desc1b.SetActive(false);
    Desc2b.SetActive(false);
    Desc3b.SetActive(false);
    Desc4b.SetActive(false);
    Desc5b.SetActive(true);
}


public void Axe2()
{

    if(campsitedeposit.campWood >= 50)
    {

        if(campsitedeposit.campStone >= 50)
        {

            if(campsitedeposit.campLeather >= 50)
            {

                if(campsitedeposit.campFiber >= 50)
                {

                    equipment.axeTier = 2;
                    campsitedeposit.campWood -= 50;
                    campsitedeposit.campStone -= 50;
                    campsitedeposit.campLeather -= 50;
                    campsitedeposit.campFiber -= 50;
                    Upgrade1a.SetActive(false);
                    Upgrade1b.SetActive(true);
                }
            }
        }
        
    }
}

public void Axe3()
{
    if(campsitedeposit.campWood >= 100)
    {

        if(campsitedeposit.campStone >= 100)
        {

            if(campsitedeposit.campLeather >= 100)
            {

                if(campsitedeposit.campFiber >= 100)
                {
                    
                    equipment.axeTier = 3;
                    campsitedeposit.campWood -= 100;
                    campsitedeposit.campStone -= 100;
                    campsitedeposit.campLeather -= 100;
                    campsitedeposit.campFiber -= 100;
                }
            }
        }
        
    }
}

public void Pick2()
{
    if(campsitedeposit.campWood >= 50)
    {

        if(campsitedeposit.campStone >= 50)
        {

            if(campsitedeposit.campLeather >= 50)
            {

                if(campsitedeposit.campFiber >= 50)
                {
                    
                    equipment.pickTier = 2;
                    campsitedeposit.campWood -= 50;
                    campsitedeposit.campStone -= 50;
                    campsitedeposit.campLeather -= 50;
                    campsitedeposit.campFiber -= 50;
                    Upgrade2a.SetActive(false);
                    Upgrade2b.SetActive(true);
                }
            }
        }
        
    }
}

public void Pick3()
{
    if(campsitedeposit.campWood >= 100)
    {

        if(campsitedeposit.campStone >= 100)
        {

            if(campsitedeposit.campLeather >= 100)
            {

                if(campsitedeposit.campFiber >= 100)
                {
                    
                    equipment.pickTier = 3;
                    campsitedeposit.campWood -= 100;
                    campsitedeposit.campStone -= 100;
                    campsitedeposit.campLeather -= 100;
                    campsitedeposit.campFiber -= 100;

                }
            }
        }
        
    }
}

public void Sickle2()
{
    if(campsitedeposit.campWood >= 50)
    {

        if(campsitedeposit.campStone >= 50)
        {

            if(campsitedeposit.campLeather >= 50)
            {

                if(campsitedeposit.campFiber >= 50)
                {
                    
                    equipment.sickleTier = 2;
                    campsitedeposit.campWood -= 50;
                    campsitedeposit.campStone -= 50;
                    campsitedeposit.campLeather -= 50;
                    campsitedeposit.campFiber -= 50;
                    Upgrade3a.SetActive(false);
                    Upgrade3b.SetActive(true);
                }
            }
        }
        
    }
}

public void Sickle3()
{
    if(campsitedeposit.campWood >= 100)
    {

        if(campsitedeposit.campStone >= 100)
        {

            if(campsitedeposit.campLeather >= 100)
            {

                if(campsitedeposit.campFiber >= 100)
                {
                    
                    equipment.sickleTier = 3;
                    campsitedeposit.campWood -= 100;
                    campsitedeposit.campStone -= 100;
                    campsitedeposit.campLeather -= 100;
                    campsitedeposit.campFiber -= 100;
                }
            }
        }
        
    }
}

public void Spear2()
{
    if(campsitedeposit.campWood >= 50)
    {

        if(campsitedeposit.campStone >= 50)
        {

            if(campsitedeposit.campLeather >= 50)
            {

                if(campsitedeposit.campFiber >= 50)
                {
                    
                    equipment.spearTier = 2;
                    campsitedeposit.campWood -= 50;
                    campsitedeposit.campStone -= 50;
                    campsitedeposit.campLeather -= 50;
                    campsitedeposit.campFiber -= 50;
                    Upgrade4a.SetActive(false);
                    Upgrade4b.SetActive(true);
                }
            }
        }
        
    }
}

public void Spear3()
{
    if(campsitedeposit.campWood >= 100)
    {

        if(campsitedeposit.campStone >= 100)
        {

            if(campsitedeposit.campLeather >= 100)
            {

                if(campsitedeposit.campFiber >= 100)
                {
                    
                    equipment.spearTier = 3;
                    campsitedeposit.campWood -= 100;
                    campsitedeposit.campStone -= 100;
                    campsitedeposit.campLeather -= 100;
                    campsitedeposit.campFiber -= 100;
                }
            }
        }
        
    }
}

public void Club2()
{
    if(campsitedeposit.campWood >= 50)
    {

        if(campsitedeposit.campStone >= 50)
        {

            if(campsitedeposit.campLeather >= 50)
            {

                if(campsitedeposit.campFiber >= 50)
                {
                    
                    equipment.clubTier = 2;
                    campsitedeposit.campWood -= 50;
                    campsitedeposit.campStone -= 50;
                    campsitedeposit.campLeather -= 50;
                    campsitedeposit.campFiber -= 50;
                    Upgrade5a.SetActive(false);
                    Upgrade5b.SetActive(true);
                }
            }
        }
        
    }
}

public void Club3()
{
    if(campsitedeposit.campWood >= 100)
    {

        if(campsitedeposit.campStone >= 100)
        {

            if(campsitedeposit.campLeather >= 100)
            {

                if(campsitedeposit.campFiber >= 100)
                {
                    
                    equipment.clubTier = 3;
                    campsitedeposit.campWood -= 100;
                    campsitedeposit.campStone -= 100;
                    campsitedeposit.campLeather -= 100;
                    campsitedeposit.campFiber -= 100;
                }
            }
        }
        
    }
}
}