using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public ObjectPool bulletPool;
    public Transform muzzle;
    public PlayerController player;
    public int curAmmo;
    public int maxAmmo;
    public bool infiniteAmmo;
    public float bulletSpeed;
    public float fireRate;
    public float lastShootTime;
    public bool isPlayer;


    void Awake() 
    {
        //are we attached to the player?
        if(GetComponent<PlayerController>())
        {
            isPlayer = true;
        }
    }
    public bool CanShoot()
    {
        if(Time.time - lastShootTime >= fireRate)
        {
            if(curAmmo > 0 || infiniteAmmo == true)
                return true;
        }
        return false;
    }
    
    public void Shoot()
    {
        lastShootTime = Time.time;
        curAmmo--;

            GameObject bullet = bulletPool.GetObject();
            bullet.transform.position = muzzle.position;
            bullet.transform.rotation = muzzle.rotation;

            //Set Velocity
            bullet.GetComponent<Rigidbody>().velocity = muzzle.forward * bulletSpeed;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
