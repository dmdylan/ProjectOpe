using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollider : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Can" || collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
        }
    }
}
