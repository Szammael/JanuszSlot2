using System.Collections.Generic;
using UnityEngine;

class Planets : MonoBehaviour
{
    [SerializeField] float mass;

    Vector3 velocity = Vector3.zero;

    static List<Planets> all = new();

    void OnValidate()
    {
        const float sizeMultiplier = 0.25f;
        float size = Mathf.Pow(mass, 1f / 3);
        transform.localScale = Vector3.one * size * sizeMultiplier;
    }

    void OnEnable()
    {
        all.Add(this);
    }

    void OnDisable()
    {
        all.Remove(this);  
    }

    void FixedUpdate()
    {
        Vector3 selfPosition= transform.position;

        foreach(Planets other in all) 
        {
            Vector3 otherPosition = other.transform.position;            
            Vector3 distanceVector= selfPosition - otherPosition;
            
            if(distanceVector==Vector3.zero) 
            { continue; }

            float distance = distanceVector.magnitude;
            Vector3 directionVector = distanceVector / distance;

            float force = mass * other.mass / distance;
            Vector3 forceVector=directionVector* force;
            other.velocity += forceVector / other.mass * Time.fixedDeltaTime;
        }

    }

    void Update()
    {
        transform.position +=velocity*Time.deltaTime;
    }

}
