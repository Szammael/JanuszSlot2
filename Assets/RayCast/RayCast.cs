using UnityEngine;

class RayCast : MonoBehaviour
{
    [SerializeField] Transform cursor3D;
    [SerializeField] float explosionRange=2;
    [SerializeField] float maximumExplosionForce=10;
    [SerializeField] ParticleSystem visualEffect;
    [SerializeField] AudioSource soundEffect;
    void Update()
    {
        // Ray ray = new Ray(Vector3.up, Vector3.right);
        // Ray2D ray2D = new Ray2D(Vector2.up, Vector2.right);


        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if(Physics.Raycast(mouseRay, out RaycastHit hit))
        {
            cursor3D.position = hit.point;  
            
            if(Input.GetMouseButtonDown(0)) 
            {
                Explode(hit.point);
            }

        }

    }

    void Explode(Vector3 position)
    {
        visualEffect.Play();
        soundEffect.Play();

        Rigidbody[] allRigidBodies =FindObjectsOfType<Rigidbody>();
       foreach (Rigidbody rb in allRigidBodies)
        {
            Vector3 distanceVector = rb.position - position;
            float distance = distanceVector.magnitude;
            if (distance < explosionRange)
            {
                Vector3 directionVector = distanceVector.normalized;
                float explosionForce = (1 - (distance / explosionRange)) * maximumExplosionForce;
                Vector3 explosionForceVector = directionVector * explosionForce;

                rb.AddForce(explosionForceVector);
            }
        }
    }
}
