using Unity.Mathematics;
using UnityEngine;

public class Enemy_script : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPosition;
    private float timer;
    private void Start()
    { 

    }

    private void Update()
    {
        timer+= Time.deltaTime;
        if (timer>2)
        {
            timer=0;
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject temp = Instantiate(bullet, bulletPosition.position, quaternion.identity);
    }
 private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.CompareTag("Bullet")) 
       { Destroy(gameObject);}
    }
}
