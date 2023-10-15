using UnityEngine;

 class MethodPractice : MonoBehaviour
{
    void Start()
    {
        float a = Mathf.Pow(2, 7);  //hatványozás
        float b= Mathf.Pow(6, 5);
        float c= Mathf.Pow(10.2f, 50.1f);

        float d = Mathf.Abs(-12);       //12
        float e = Mathf.Sign(-12);      //-1
        float f = Mathf.Sign(333);      // 1
        float g = Mathf.Round(13.66f);  //14
        float h = Mathf.Ceil(11.11f);   //12
        float i = Mathf.Floor(11.98f);  //11
        float j = Mathf.Max(12, 55);    //55
        float k = Mathf.Min(12, 55);    //12

    }

    float Power(float baseNumber, int exponent) 
    {
        float accum = 1;
        for (int i = 0; i < exponent; i++)
        {
            accum = accum * baseNumber;
        }
        return accum;
    }

    void SumOfFirstNumber(int n) 
    {
        if(n<0) return;

        int acc = 0;
        for (int m = 1; m <= n; m++)
        {
            acc = acc + m;
        }
        Debug.Log(acc);
    }

    float Abs(float n) 
    {
        if (n < 0) 
        {
            n = -n;
        }
        return n;
    }

    float Sign(float n) 
    {
        if (n < 0) 
        {
            return -1; 
        }
        else 
        {
            return 1;
        }
    }

}
