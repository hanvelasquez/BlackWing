using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsScreen : MonoBehaviour
{
    public GameObject settings;
    public GameObject menu;

    void Start()
    {

    }

    void Update()
    {

    }
    public void GotoSettings()
    {
        if (settings.activeInHierarchy==true)
        {
            settings.SetActive(false);
            menu.SetActive(true);
        }
        else
        {
            settings.SetActive(true);
            menu.SetActive(false);
        }
    }
}
