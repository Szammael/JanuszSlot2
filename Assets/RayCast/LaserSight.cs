using UnityEngine;

class LaserSight : MonoBehaviour
{
    [SerializeField] Transform[] inBetweenPoints;

    void Update()
    {
        Vector3 startPoint= transform.position;
        Ray ray= new Ray(startPoint, transform.forward);

        bool isHit = Physics.Raycast(ray, out RaycastHit hit);
        if (isHit)
        {
            Vector3 endPoint = hit.point;
            Vector3 step = endPoint - startPoint;
            step /= inBetweenPoints.Length - 1;

            foreach(Transform t in inBetweenPoints) 
            { 
                t.position= startPoint;
                startPoint += step;
            }
        }

        foreach(Transform t in inBetweenPoints)
        {
            t.gameObject.SetActive(isHit);

        }

    }    

}
