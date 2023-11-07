using UnityEngine;

class StepCounter : MonoBehaviour
{
    [SerializeField] Vector2 a, b;
    
    [SerializeField] int jumpCount;
    [SerializeField] Vector2 jumpVector;

    void OnValidate()
    {
        float d=Vector2.Distance(a, b);    
        jumpCount=Mathf.CeilToInt(d);
        jumpVector = (b - a) / jumpCount;

    }
}
