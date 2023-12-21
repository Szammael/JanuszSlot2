using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed = 25f;
    [SerializeField] float destroyDistance = 10f;
    [SerializeField] float destroyTime = 2;
 
    Vector3 startPoint;
    

    void Start()
    {
        startPoint= transform.position;
        Invoke(nameof(DestroySelf), destroyTime);
        //Destroy(gameObject, destroyTime);     ugyanaz
    }

    void DestroySelf() 
    { 
        Destroy(gameObject); 
    }

    void Update()
    {

        Vector3 dir= transform.forward;
        transform.position += dir * speed * Time.deltaTime;

        Vector3 point= transform.position;

        bool isOutOfRange = Vector3.Distance(point, startPoint)>destroyDistance;
        if (isOutOfRange)
        {
            DestroySelf();
        }

    }
}
