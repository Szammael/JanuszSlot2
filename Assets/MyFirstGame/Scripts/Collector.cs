using TMPro;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField] int startCoins = 0;
    [SerializeField] TMP_Text uiText;
    int currentCoins;

    public int GetCurrentCoins()
    { 
        return currentCoins; 
    }

    void Start()
    {
        currentCoins = startCoins;
        UpdUIText();
    }

    public void Collection(int coins)
    {
        
        currentCoins += coins;
        UpdUIText();
    }

    void UpdUIText()
    {
        uiText.text = currentCoins.ToString();
    }
}