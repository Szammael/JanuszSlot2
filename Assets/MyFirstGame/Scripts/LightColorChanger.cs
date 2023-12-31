using UnityEngine;

public class LightColorChanger : MonoBehaviour
{
    [SerializeField] Color color1 = Color.red;
    [SerializeField] Color color2 = Color.blue;

    [SerializeField] Light lighting;
    [SerializeField] float speedMultiplier;
    void Update()
    {
        float t= Mathf.Sin( Time.time * speedMultiplier);

        t = (t / 2f)+0.5f;
       
        Color c = Color.Lerp(color1, color2, t);

        lighting.color = c;   
    }
}
