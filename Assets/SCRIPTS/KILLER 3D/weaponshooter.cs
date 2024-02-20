using UnityEngine;

public class weaponshooter : MonoBehaviour
{

    public AudioSource gunaudio;
   

    public Camera maincamera;
    public firescript firescripts;
    
    public ParticleSystem shooteffect;
    public ParticleSystem chunkparticles;
    public GameObject particalsystem;
    public ParticleSystem muzzleflash;

    public float firerate = 0.20f;
    public float time_to_nextfire=0;
   
    public float reload = 40f;
    public float re = 0;
    
    public GameObject gameobject;
    public bool reaction=false;
    public float damage = 20;
    public AudioSource headshot;



    void Update()
    {
        reaction = false;
       
        if (firescripts.pressed && Time.time>=time_to_nextfire)
        {
            time_to_nextfire = Time.time + 0.20f;
            if (re >= 40)
            {
               
                shoot();
                gunaudio.Play();
            }
            else
            {
                ParticleSystem muzzle = Instantiate(muzzleflash, muzzleflash.transform.position, Quaternion.identity);
                Destroy(muzzle, 1);

                gunaudio.Play();
                shoot();
               // re += 1;
            }
            
           
        }
        
    }
    public void shoot()
    {
        RaycastHit hits;
        
        if(Physics.Raycast(maincamera.transform.position,maincamera.transform.forward,out hits))
        {
            
           
            if (hits.transform.tag=="head")
            {

               Zombie_health health = hits.transform.GetComponent<Zombie_health>();
               health.Damage(100);
               GameObject part =Instantiate(particalsystem, hits.point, Quaternion.identity);
                Destroy(part, 1);
                headshot.Play();

            }

            if (hits.transform.tag == "spine")
            {
                Zombie_health health = hits.transform.GetComponent<Zombie_health>();
                health.Damage(10);
                GameObject part = Instantiate(particalsystem, hits.point, Quaternion.identity);
                Destroy(part, 1);

            }

            ParticleSystem partical =Instantiate(shooteffect, hits.point, Quaternion.LookRotation(hits.normal));
            Destroy(partical, 2);
        }
    }
}
