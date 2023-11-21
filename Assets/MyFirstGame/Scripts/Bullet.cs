using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed = 25f;
    [SerializeField] float destroyDistance = 10f;

    Vector3 startPoint;

    void Start()
    {
        startPoint= transform.position; 
    }

    void Update()
    {

        Vector3 dir= transform.forward;
        transform.position += dir * speed * Time.deltaTime;

        Vector3 point= transform.position;

        bool isOutOfRange = Vector3.Distance(point, startPoint)>destroyDistance;
        if(isOutOfRange)
            Destroy(gameObject);
    }
}
