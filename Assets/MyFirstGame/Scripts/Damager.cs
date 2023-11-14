using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] int damage;
    void OnTriggerEnter(Collider other)
    {
        GameObject go= other.gameObject;
        Damagable damagable = go.GetComponent<Damagable>();
        if(damagable != null )
        {
            damagable.Damage(damage);


        }

    }
}
