using System;
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    void Start()
    {
        int[] integers;
        
        integers= new int[10];
        int[] ints2 = new int[124];

        ints2[0] = 3;       //Elsõ elem nullás index
        ints2[1] = 34;
        //...
        ints2[123] = 12345; //Utolsó elem

        string[] strings=new string[] {"Alma", "Barack", "Citrom"};
        Debug.Log(strings[1]);
        int lenght = strings.Length;
        //Utolsó elemlekérése

        string last = strings[lenght-1];
        string lastAlt = strings[^1];

        string[] strings2 ={ "Alma", "Barack", "Citrom" };  //Ugyanaz

        /* int[] integers3 = new int[100];
         int a = 0,  b = 1 ;
         while (a < integers3.Length)
         {
             integers3[a] = b;
             a++;
             b++;

         }
        */
        int[] integers3 = new int[100];
        for(int i= 0; i<integers3.Length; i++)
        {
            integers3[i] = i + 1; 

        }


        int x = 12;
        int y = x;
        y += 100;
        Debug.Log(x);               //12


        int[] ints4 = { 1, 2, 3 };
        int[] ints5 = ints4;
        ints5[0] += 100;
        Debug.Log(ints4[0]);        //101

    }

    int GetIndex(string[] array, string search)
    {
        for(int i=0; i<array.Length; i++) 
        {
            if (array[i] == search)
                return i;

        }
        return -1;

    }

    string[] GetReversed(string[] original) 
    {
        string[] strings = new string[original.Length];
        for(int i = 0; i < original.Length; i++)
            {
             strings[i] = original[original.Length - 1 - i];

            }
        return strings;
    }



}

//Array.IndexOf(string1, searched)
