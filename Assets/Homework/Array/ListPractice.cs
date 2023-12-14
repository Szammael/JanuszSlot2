using System.Collections.Generic;
using UnityEngine;

class ListPractice : MonoBehaviour
{
    [SerializeField] List<string> strings;
    
    void Start()
    {
        List<float> floatList = new List<float>();
        floatList.Add(23.44f);
        floatList.Add(1.0f);
        floatList.Add(12.44f);

        float f = floatList[2];

        int count = floatList.Count;    //darabsz�m

        floatList.Remove(23.44f);       //az adott �rt�ket kiveszi, ha van

        floatList.RemoveAt(0);          //A 0. elemet kiveszi

        floatList.Insert(0, 11.9f);     //(hov�, mit)

        int index = floatList.IndexOf(12.44f);

        floatList.Clear();              //�sszes elem t�rl�se

        List<string> shoppingList = new () {"toj�s","k�rte","alma","tej","zsemle" };
        shoppingList.Sort();            //sorba rendez�s

        foreach(string item in shoppingList) 
        { 
            Debug.Log(item);
        }
                                        //foreach minden elemen v�gig megy egy list�ban az elej�t�l a v�g�ig
        

    }

}
