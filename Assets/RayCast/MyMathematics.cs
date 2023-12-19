using UnityEngine;

public class MyMathematics : MonoBehaviour
{
    float Min(float[] array)
    { 
        float min = float.MaxValue;
        for(int i=0;i<array.Length;i++) 
        { 
            if (array[i] < min) 
            { 
            min= array[i];
            }
        }
        return min;
    }

    float Max(float[] array) 
    {
        float max = float.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < max)
            {
                max = array[i];
            }
        }
        return max;
    }

    int[] GetFibonacci(int count)
    {
        int[] fib = new int[count];
        if (count > 0)
            fib[0] = 0;
        if(count > 1)
            fib[1] = 1;

        for (int i = 2; i < count; i++)
        { 
            fib[i] = fib[i-1] + fib[i-2]; 
        }
        return fib;
    }


    

}
