using UnityEngine;

class Testscript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello World!");
        Debug.Log($"Hello {name}!");

        //Ez egy komment, kis barátom... A sor végéig
        /* Komment
        ameddig 
        a szemed 
        ellát...*/

        //----------------------------------------------

        //Változók

        int myFirstVariable = 12;

        Debug.Log(myFirstVariable);

        myFirstVariable = 7;

        Debug.Log(myFirstVariable);

        int myInt = 5;
        float myFloat = 45.67f;
        string myText = "Ez itt a Mátrix!";
        bool myBool = true;
        bool myBool1 = false;

        myBool = false;


    }
}