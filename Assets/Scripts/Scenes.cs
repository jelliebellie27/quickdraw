using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    // Start is called before the first frame update
    public void SeeIntro()
    {
        SceneManager.LoadScene("Intro");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Play");
    }

    public void LeaveGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
