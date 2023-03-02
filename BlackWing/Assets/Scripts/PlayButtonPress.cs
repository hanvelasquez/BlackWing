using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonPress : MonoBehaviour
{
    public void StartIntro()
    {
        SceneManager.LoadScene("IntroText");
    }
}
