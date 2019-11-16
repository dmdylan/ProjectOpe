using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GunController : MonoBehaviour
{
    Camera _camera = null;  // cached because Camera.main is slow, so we only call it once.
    public GameObject endOfBarrel;
    
    void Start()
    {
        _camera = Camera.main;
    }


    void Update()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        Quaternion targetRotation = Quaternion.LookRotation(ray.direction);
        transform.rotation = targetRotation;
    }
}

