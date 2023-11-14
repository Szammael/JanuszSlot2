using TMPro;
using UnityEngine;

public class Damagable : MonoBehaviour
{
    [SerializeField] int startHealth = 10;
    [SerializeField] TMP_Text uiText;
    //[SerializeField] GameManager gameManager;

    int currentHealth;

    public int GetCurrentHealth()
    {
        return currentHealth; 
    }   

    void Start()
    {
        
        currentHealth = startHealth;
        UpdUIText();
    }


    //fontos, hogy public, ha máshoz is szükséges 
    public void Damage(int damage)
    {
        if (currentHealth <= 0) return;
        currentHealth -= damage;
        currentHealth = Mathf.Max(0, currentHealth);
        
        if(currentHealth<=0)
        {
            GameManager gm = FindObjectOfType<GameManager>();
            gm.OnGameEnded(); 
        }

        UpdUIText();
    }

     void UpdUIText()
    {
        uiText.text = "Health: " + currentHealth.ToString();
    }

}
