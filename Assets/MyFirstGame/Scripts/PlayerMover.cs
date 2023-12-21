using UnityEngine;

class PlayerMover : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float angularSpeed;
    [SerializeField] Transform cameraTransform;

    [SerializeField] Damagable damagable;
    [SerializeField] Animator animator;

    void OnValidate()
    {
        if (animator == null)
        { animator = GetComponent<Animator>(); }
        if(damagable == null) 
        { damagable=GetComponent<Damagable>(); }
    }
    void Update()
    {
        bool isDead = damagable.GetCurrentHealth() <= 0 ;
        if(isDead) return;
       
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 cameraForward = cameraTransform.forward;
        Vector3 cameraRight = cameraTransform.right;

        Vector3 inputVector = x * cameraRight + z * cameraForward;
        inputVector.y = 0;

        bool isRunning = inputVector != Vector3.zero;
        animator.SetBool("IsRunning", isRunning);
        if (isRunning)
        {

            inputVector.Normalize();
            Vector3 velocity = inputVector * speed;
            transform.position += velocity * Time.deltaTime;
            
            Quaternion targetRotation= Quaternion.LookRotation(inputVector);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, angularSpeed * Time.deltaTime);
        }

    }
}
