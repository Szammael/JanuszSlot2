using UnityEngine;

class NumtoString : MonoBehaviour
{
    [SerializeField] int number;    
    [SerializeField] string text;    

    void OnValidate()
    {
      
        text = string.Empty;     

        for (int i = 1; i <= number; i++)
        {
            text = text + i;

            if (i != number)   
                text += ", ";  
        }
    }
}
