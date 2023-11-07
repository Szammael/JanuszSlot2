using UnityEngine;

class PlayerMover : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float angularSpeed;
    [SerializeField] Transform cameraTransform;
    void Update()
    {
       
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 cameraForward = cameraTransform.forward;
        Vector3 cameraRight = cameraTransform.right;

        Vector3 inputVector = x * cameraRight + z * cameraForward;
        inputVector.y = 0;

        if (inputVector != Vector3.zero)
        {
            inputVector.Normalize();
            Vector3 velocity = inputVector * speed;
            transform.position += velocity * Time.deltaTime;
            
            Quaternion targetRotation= Quaternion.LookRotation(inputVector);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, angularSpeed * Time.deltaTime);
        }

    }
}
