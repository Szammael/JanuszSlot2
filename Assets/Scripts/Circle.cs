using UnityEngine;

 class Circle : MonoBehaviour
{

    [SerializeField] float radius = 12;

    void Start()
    {

        //float radius = 7;

        float circumference = (2*radius)*Mathf.PI ;
        float area = (radius*radius)*Mathf.PI;

        Debug.Log($"Circumference {circumference}");
        Debug.Log($"Area {area}");

        area = Mathf.Pow(area, 2);

        Debug.Log($"Area {area}");

    }

}
