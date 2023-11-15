using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] int coins = 1;

    void OnTriggerEnter(Collider other)
    {
        GameObject go = other.gameObject;
        Collector collector = go.GetComponent<Collector>();
        
        if (collector != null)
        {
            collector.Collection(coins);

        }
        

    }


}
