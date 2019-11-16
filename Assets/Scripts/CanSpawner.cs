using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanSpawner : MonoBehaviour
{
    public Transform[] spawnLocations;

    public GameObject[] popCans;

    [SerializeField] private float canForceMin = 0f;
    [SerializeField] private float canForceMax = 0f;
    [SerializeField] private float canForcePositionMin = 0f;
    [SerializeField] private float canForcePositionMax = 0f;
    private float forceAppliedToCan;
    private float forcePositionAppliedToCan;

    public FloatValue spawnTimeMax;

    private void Start()
    {
        forceAppliedToCan = Random.Range(canForceMin, canForceMax);
        forcePositionAppliedToCan = Random.Range(canForcePositionMin, canForcePositionMax);
        Invoke("SpawnCans", Random.Range(0, spawnTimeMax.Value));
    }

    private void SpawnCans()
    {
        int spawnIndex = Random.Range(0, spawnLocations.Length);
        int objectIndex = Random.Range(0, popCans.Length);
        float delay = Random.Range(0, spawnTimeMax.Value);

        GameObject popCan = Instantiate(popCans[objectIndex], spawnLocations[spawnIndex].position, spawnLocations[spawnIndex].rotation) as GameObject;
        Rigidbody popCanRB = popCan.GetComponent<Rigidbody>();

        popCanRB.AddForce(spawnLocations[spawnIndex].forward * forceAppliedToCan);
        popCanRB.AddForceAtPosition(popCanRB.transform.up * forcePositionAppliedToCan, popCanRB.transform.position);
        popCanRB.AddRelativeTorque(Vector3.right * 100);

        Invoke("SpawnCans", delay);
    }
}
