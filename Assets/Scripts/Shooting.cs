﻿using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour{

    public float speed = 20;

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Spawner.Spawn("Bullet");
            Rigidbody instantiatedProjectile = bullet.GetComponent<Rigidbody>();
            instantiatedProjectile.transform.position = transform.position;
            instantiatedProjectile.transform.rotation = transform.rotation;

            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
        }
    }
}
