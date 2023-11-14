using UnityEngine;

 class Carcontrol : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] float angularSpeed = 30;    


    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        Vector3 direction = transform.forward * forwardInput;

        transform.position += direction * speed * Time.deltaTime;

        float directionalInput = Input.GetAxis("Horizontal");
        float rotationDirection = directionalInput * forwardInput;
        transform.Rotate(0, rotationDirection * angularSpeed * Time.deltaTime, 0);





    }
}
