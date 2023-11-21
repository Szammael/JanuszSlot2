using UnityEngine;

 class Autorotator : MonoBehaviour
{
    [SerializeField] float angularSpeed = 360;
    [SerializeField] Space simSpace = Space.World;

    void Update()
    {

        transform.Rotate(0, angularSpeed * Time.deltaTime, 0, simSpace);
        
    }
}
