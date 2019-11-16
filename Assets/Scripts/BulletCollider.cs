using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollider : MonoBehaviour
{
    public IntValue playerPoints;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Can")
        {
            Destroy(collision.gameObject);
            playerPoints.Value += 5;
        }
    }
}
