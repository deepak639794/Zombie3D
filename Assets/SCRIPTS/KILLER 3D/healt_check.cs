using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healt_check : MonoBehaviour
{
    public Zombie_health zombie_Health;
    public Zombie_health zombie_Health1;
    public left_enemy left;
    public GameObject plasmaexposions;

    void Update()
    {
        if (zombie_Health.currenthealth <= 0 || zombie_Health1.currenthealth <= 0)
        {
            destroy();
            left.Enemyleft();
            GameObject palsma = Instantiate(plasmaexposions, transform.position, Quaternion.identity);
            Destroy(palsma, 2);
        }

    }
    public void destroy()
    {

        Destroy(gameObject);

    }
}
