using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PLAYPAUSE : MonoBehaviour
{
    public AudioSource lighter;
   public void Play()
    {
        lighter.Play();
        SceneManager.LoadScene("complete");
    }
    public void Exit()
    {
        lighter.Play();
        Application.Quit();
    }
    public void Instruction()
    {
        lighter.Play();
        SceneManager.LoadScene("instructions");
    }

    
}
