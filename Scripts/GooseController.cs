using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooseController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
        }
    }
}
