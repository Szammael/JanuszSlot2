using UnityEngine;

class HWSOLUTION_10_2 : MonoBehaviour
{
    [SerializeField] int number = 10; 
    void Start()
    {
        int sum = 0;

        for(int i=1; i<=number * 2; i += 2) 
        { 
            sum = sum + i;        
        }
        Debug.Log("Összeg: " + sum);

        float mean = (float)sum / number;
        Debug.Log("Átlag: " + mean);
        



    }
}