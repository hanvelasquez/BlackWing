using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoMenu : MonoBehaviour
{
    public void BacktoScreen()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
