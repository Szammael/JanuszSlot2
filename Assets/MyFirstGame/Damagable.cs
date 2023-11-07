using UnityEngine;

public class Damagable : MonoBehaviour
{
    [SerializeField] int startHealth = 10;

    public int currentHealth;

    void Start()
    {
        currentHealth = startHealth;    
    }


    //fontos, hogy public, ha m�shoz is sz�ks�ges 
    public void Damage(int damage) 
    {
        if (currentHealth <= 0) return; 
        currentHealth -= damage;
        currentHealth=Mathf.Max(0, currentHealth);
        Debug.Log(currentHealth);
    }

  
}
