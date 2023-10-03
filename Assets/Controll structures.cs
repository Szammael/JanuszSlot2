using UnityEngine;

class Controllstructures : MonoBehaviour
{
    [SerializeField] int number = 1;
    void Start()
    {
        
        if(number > 0)
        {
            Debug.Log("Pozitív szám");
        }
        else if(number < 0)
        { 
            Debug.Log("Negatív szám"); 
        }
        else
        {
            Debug.Log("A szám nulla");
        }

        if (number % 2 == 0)
            Debug.Log("Páros szám");

        else
            Debug.Log("Páratlan szám");

        //-------------------------
        string isEven;
        isEven= number % 2 == 0 ? "EVEN" : "ODD";


        //-------------------------------------------------------
        int i = 1;
        while(i<100)
        {
            Debug.Log(i * i);
            i++;
        }

        for (int j = 100; j > 0; j--)
        {
            Debug.Log(j * j);
        }

        int k = 1;
        
        do
        {

            Debug.Log(k * k);

        } while ( k<=100);

        //----------------------

    }
    
}
