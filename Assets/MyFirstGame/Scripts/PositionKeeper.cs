using UnityEngine;

class PositionKeeper : MonoBehaviour
{
    [SerializeField] Vector3 sphereCenter;
    [SerializeField] float sphereRadius;
void Update()
    {
     
        Vector3 selfPoint= transform.position;
        Vector3 distanceVec = selfPoint - sphereCenter;
        float distance = (selfPoint - sphereCenter).magnitude;

        bool isOut= distance > sphereRadius;

        if(isOut)
        {
            Vector3 offset = distanceVec.normalized * sphereRadius;
            transform.position = sphereCenter + offset;
        }

    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(sphereCenter, sphereRadius);
    }
}
