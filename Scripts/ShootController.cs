using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    public GameObject bullet;
    public Transform pointOfFire;
    [SerializeField] private float bulletSpeed = 8f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SpawnABullet();
        }
    }

    private void SpawnABullet()
    {
        GameObject newbullet = Instantiate(bullet, pointOfFire.position, pointOfFire.rotation) as GameObject;
        newbullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
            //(transform.forward * bulletSpeed);
    }
}
