using UnityEngine;
using UnityEngine.UI;

public class left_enemy : MonoBehaviour
{
    public Text E_left;

    public float left = 15;
    void Update()
    {
        E_left .text= left.ToString();
    }
    public void Enemyleft()
    {
        left -= 1;
    }
}
