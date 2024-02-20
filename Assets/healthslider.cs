using UnityEngine;
using UnityEngine.UI;


public class healthslider : MonoBehaviour
{
    public Slider slider;
    public float currenthealth=30;
    public Animator cameradrop;
    //public Animator failed;
    public GameObject failed;
    public GameObject gameover;
    public float failedtime;

    public void Sethealth(float health)
    {
        slider.value -= health ;
    }
    void Update()
    {
        if (slider.value == 0)
        {
            //Time.timeScale = 0;
            cameradrop.SetBool("drop", true);
            
            failed.SetActive(true);
            gameover.SetActive(true);
           // Time.timeScale= 0f;
        }
        
    }

}
