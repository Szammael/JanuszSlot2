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

        int count = floatList.Count;    //darabszám

        floatList.Remove(23.44f);       //az adott értéket kiveszi, ha van

        floatList.RemoveAt(0);          //A 0. elemet kiveszi

        floatList.Insert(0, 11.9f);     //(hová, mit)

        int index = floatList.IndexOf(12.44f);

        floatList.Clear();              //összes elem törlése

        List<string> shoppingList = new () {"tojás","körte","alma","tej","zsemle" };
        shoppingList.Sort();            //sorba rendezés

        foreach(string item in shoppingList) 
        { 
            Debug.Log(item);
        }
                                        //foreach minden elemen végig megy egy listában az elejétõl a végéig
        

    }

}
