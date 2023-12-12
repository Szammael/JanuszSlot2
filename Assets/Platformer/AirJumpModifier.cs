using UnityEngine;

public class AirJumpModifier : MonoBehaviour
{

    bool deleteOnContact = false;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlatformerController pc))
        {
            pc.FillJumpBudget();

            if(deleteOnContact) 
                {Destroy(gameObject); }
        }
    }
}
