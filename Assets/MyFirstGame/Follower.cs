using UnityEngine;

class Follower : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform target;
    [SerializeField] float maxDistance=2;

    void Update()
    {
        Vector3 selfPosition = transform.position;
        Vector3 targetPosition = target.position;

        float distace=Vector3.Distance(selfPosition, targetPosition);

        Vector3 directionVector = targetPosition - selfPosition;
        if (distace < maxDistance) return;
        
        directionVector.Normalize();

        if (directionVector == Vector3.zero) return;
        
        transform.rotation = Quaternion.LookRotation(directionVector);
        transform.position = Vector3.MoveTowards(selfPosition, targetPosition, speed * Time.deltaTime);//Jelenlegi, Cél, Lépéshossz 
        
        
    }
}
