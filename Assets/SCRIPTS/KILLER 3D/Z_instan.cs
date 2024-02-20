using System.Collections;

using UnityEngine;

public class Z_instan : MonoBehaviour
{
    public GameObject zombie;
    private float zomb_count = 0;
    public float no_of_zombie=15;
    public GameObject yulk;
    private float i;
    public Transform GameObject;
    
   
 
   void Start()
    {
            StartCoroutine(zombieinstantiate());
    }


    public IEnumerator zombieinstantiate()
    {
        yield return new WaitForSeconds(3);
        zomb_count += 1;
      
        Instantiate(yulk, GameObject.position, Quaternion.identity);

        //Instantiate(zombie, transform.position, Quaternion.identity);
        if (zomb_count == no_of_zombie)
        {
            Destroy(gameObject);
        }
        StartCoroutine(zombieinstantiate());
    }
    

}
