using UnityEngine;

class Testscript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello World!");
        Debug.Log($"Hello {name}!");

        //Ez egy komment, kis bar�tom... A sor v�g�ig
        /* Komment
        ameddig 
        a szemed 
        ell�t...*/

        //----------------------------------------------

        //V�ltoz�k

        int myFirstVariable = 12;

        Debug.Log(myFirstVariable);

        myFirstVariable = 7;

        Debug.Log(myFirstVariable);

        int myInt = 5;
        float myFloat = 45.67f;
        string myText = "Ez itt a M�trix!";
        bool myBool = true;
        bool myBool1 = false;

        myBool = false;


    }
}