using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
class PlatformerController : MonoBehaviour
{
    [SerializeField] KeyCode jumpKey = KeyCode.Space;
    [SerializeField, HideInInspector] Rigidbody2D playerRigidBody;
    [SerializeField] float jumpSpeed = 10;
    [SerializeField] int airJumpCount = 1;
    [SerializeField] float acceleration = 10;
    [SerializeField] float maxHorizontalSpeed = 10;
    [SerializeField] Vector2 legPosition;
    [SerializeField] float legRadius;
    

    bool isGrounded = false;
    int airJumpBudget = 0;

    void OnValidate()
    {
        playerRigidBody= GetComponent<Rigidbody2D>();    
    }

    void Update()
    {
        if (isGrounded || airJumpBudget > 0)
        {
            if (Input.GetKeyDown(jumpKey))
            {
                if (!isGrounded)
                    airJumpBudget--;

                Vector2 vel = playerRigidBody.velocity;
                vel.y = jumpSpeed;
                playerRigidBody.velocity = vel; 
            }
        }
    }

    private void FixedUpdate()
    {
        float xInput = Input.GetAxis("Horizontal");
        playerRigidBody.velocity += xInput * Vector2.right * acceleration * Time.fixedDeltaTime;
        Vector2 vel = playerRigidBody.velocity;
        
        if (Mathf.Abs(vel.x) > maxHorizontalSpeed)
        {
            vel.x = maxHorizontalSpeed * Mathf.Sign(vel.x);
            playerRigidBody.velocity = vel; 
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 collisionPoint = collision.contacts[0].point;
        Vector3 localCollisionPoint = transform.InverseTransformPoint(collisionPoint);
        float legDistance = Vector3.Distance(localCollisionPoint, legPosition);
        if (legDistance <= legRadius)
        {
            airJumpBudget = airJumpCount;
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded= false;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Vector3 globalLegPosition = transform.TransformPoint(legPosition);
        Gizmos.DrawWireSphere(globalLegPosition, legRadius);
    }

    public void FillJumpBudget()
    {
        airJumpBudget= airJumpCount;
    }
}
