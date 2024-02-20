using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeleft : MonoBehaviour
{
    public Text secondstext;
    public int nexttime;
    public Text minuteText;
    public 
   
    void Update()
    {
        if (Time.time > nexttime)
        {
            if (Time.time >= 60)
            {
                minuteText.text = "1";
                nexttime = 0   ;

            }
          //  print(nexttime.ToString);

            secondstext.text = nexttime.ToString();
            nexttime = (int)Time.time + 1;
            

        }
        
    }
}
