﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {
    private Vector3 originPosition;
    private Quaternion originRotation;

    private float shake_decay;
    private float shake_intensity;




    

    public void Update()
    {
        if (shake_intensity > 0)
        {
            transform.position = originPosition + Random.insideUnitSphere * shake_intensity;
            transform.rotation = new Quaternion(
                             originRotation.x + Random.Range(-shake_intensity, shake_intensity) * .2f,
                             originRotation.y + Random.Range(-shake_intensity, shake_intensity) * .2f,
                             originRotation.z + Random.Range(-shake_intensity, shake_intensity) * .2f,
                             originRotation.w + Random.Range(-shake_intensity, shake_intensity) * .2f);
            shake_intensity -= shake_decay;
        }

    }

    public void Shake()
    {
        originPosition = transform.position;
        originRotation = transform.rotation;
        shake_intensity = .2f;
        shake_decay = 0.002f;
    }
}
