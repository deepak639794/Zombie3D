using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement ;


public class PPscript : MonoBehaviour
{
   
    public GameObject pauseimage;
    public GameObject panel;
    public Animator Panel_anim;
    public AudioSource click;
    public AudioSource Win;
    public left_enemy Left_Enemy;
    public GameObject missioncompleted;
    public GameObject completeimage;
    public float playtime=0;
    public int time=-1;
    private bool active=true;
    public GameObject overplay;

    void Update()
    {
        if (Left_Enemy.left == 0 &&active==true)
        {
            missioncompleted.SetActive(true);
            completeimage.SetActive(true);
            if (Time.time >= playtime)
            {
                Win.Play();
                playtime = Time.time + 1f;
                time = time + 1;
            }
            if (time == 2)
            {
                active = false;
            }
            
        }
        else if (active == false)
        {
            
            missioncompleted.SetActive(false);
            completeimage.SetActive(true);
            Win.Pause();
            overplay.SetActive(true);
        }
            
    }
    public void Pause()
    {
        click.Play();
        Time.timeScale = 0;
        pauseimage.SetActive(false);
        panel.SetActive(true);
        Panel_anim.SetBool("bigger",true);
        Panel_anim.SetBool("idle",false);
        

    }
    public void Continue()
    {
        click.Play();
        Time.timeScale = 1;
        panel.SetActive(false);
        pauseimage.SetActive(true);
        Panel_anim.SetBool("bigger",false);
        Panel_anim.SetBool("idle",true);
    }
   public void Quit()
    {
        click.Play();
        Application.Quit();
       
    }
    public void main_menu()
    {
        Time.timeScale = 1f;
        click.Play();
        SceneManager.LoadScene("main menu");
    }
    public void Reload()
    {
        click.Play();
        SceneManager.LoadScene("complete");

    }
}
