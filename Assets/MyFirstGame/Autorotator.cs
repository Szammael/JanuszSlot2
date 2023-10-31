using UnityEngine;

public class Autorotator : MonoBehaviour
{
    [SerializeField] float angularSpeed;

    void Update()
    {

        transform.Rotate(0, angularSpeed*Time.deltaTime, 0);
        
    }
}
