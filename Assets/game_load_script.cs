using UnityEngine;
using UnityEngine.SceneManagement;

public class game_load_script : MonoBehaviour
{
    private float loadtime = 4f;
    // Update is called once per frame
    void Update()
    {
        if (Time.time > 4)
        {
            SceneManager.LoadScene("main menu");
        }
    }
}
