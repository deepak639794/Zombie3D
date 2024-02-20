using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class load_main : MonoBehaviour
{
    public AudioSource click;
    public void loadmain()
    {
        click.Play();
        SceneManager.LoadScene("main menu");

    }
}
