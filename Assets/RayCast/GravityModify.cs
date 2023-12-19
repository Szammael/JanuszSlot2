using System.Collections.Generic;
using UnityEngine;

public class GravityModify : MonoBehaviour
{
    [SerializeField] Vector3 acceleration;
    List<Rigidbody> rigidBodies = new();

    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Rigidbody>(out var rb))
            rigidBodies.Add(rb);
    }

    void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<Rigidbody>(out var rb))
            rigidBodies.Remove(rb);
    }

    void FixedUpdate()
    {
        foreach (var rb in rigidBodies)
            rb.AddForce(acceleration, ForceMode.Acceleration);
    }
}
