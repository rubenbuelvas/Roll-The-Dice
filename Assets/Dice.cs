using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{

    public float forceMagnitude = 10f; // The magnitude of the force applied to the dice
    public float torqueMagnitude = 10f;

    private new Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Roll()
    {

        Vector3 force = Vector3.up * forceMagnitude + Random.insideUnitSphere * forceMagnitude / 2f;
        Vector3 torque = Random.insideUnitSphere * torqueMagnitude;

        rigidbody.AddForce(force, ForceMode.Impulse);
        rigidbody.AddTorque(torque, ForceMode.Impulse);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Roll();
        }
    }
}
