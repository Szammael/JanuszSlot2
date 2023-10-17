using UnityEngine;

 class Math : MonoBehaviour
{


   
    float Floor(float number)
    {
        int a = (int)number;
        number = (float)a;
        return number;
    }
    
    
    float Ceiling(float number)
    {
        int a = (int)number; //->123
        if (a == (int)number)
            return number;

        number = (float)a + 1; //->124
        return number;
    }
    
    float Round(float number)
    {
        float a = number - (int)number;
        if(a<0.5)
            return (int)number;

        else return (int)number + 1;
    }

    float Min(float a, float b) 
    {
        if (a < b) return a;
        
        else return b;
    }

    float Max(float a, float b) 
    { 
        if(a > b) return a; 
        
        else return b;  
    }
    
    bool IsPrime(int number)
    {  
    for (int i = 2; i <= number/2; i++) 
        { 
        if(number % i==0) return false;
        }
        return true;
    }
   
}
