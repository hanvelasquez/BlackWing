using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMenu: MonoBehaviour
{
    public GameObject settings;
    public GameObject menu;

    void Start()
    {

    }

    void Update()
    {

    }
    public void GotoReturnMenu()
    {
        if (menu.activeInHierarchy==true)
        {
            menu.SetActive(false);
            settings.SetActive(true);
        }
        else
        {
            menu.SetActive(true);
            settings.SetActive(false);
        }
    }
}
