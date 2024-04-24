using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public Text ClicksTotalText;

    float TotalClicks;

    


    public void AddClicks()
    {
        TotalClicks+= Mathf.Pow(5,SceneManager.GetActiveScene().buildIndex);
        ClicksTotalText.text = TotalClicks.ToString("0");
    }

    //public void AddClicksIron()
    //{
    //    TotalClicks += 5;
    //    ClicksTotalText.text = TotalClicks.ToString("0");
    //}

    //public void AddClicksGold()
    //{
    //    TotalClicks += 25;
    //    ClicksTotalText.text = TotalClicks.ToString("0");
    //}

    void Update()
    {
        if (TotalClicks > Mathf.Pow(10, SceneManager.GetActiveScene().buildIndex)*100)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            

        }

    }
}
