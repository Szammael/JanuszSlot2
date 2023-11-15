using UnityEngine;

public class PlayArea : MonoBehaviour
{
    [SerializeField] Vector3 playAreaCenter = Vector3.zero;
    [SerializeField] Vector3 playAreaSize = new Vector3(50,1,50) ;

    

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireCube(playAreaCenter, playAreaSize);
    }

    void Update()
    {
        float ax = playAreaSize.x / 2 - 0.5f;
        float ay = playAreaSize.y / 2 - 0.5f;
        float az = playAreaSize.z / 2 - 0.5f;
        Vector3 selfPoint = transform.position;
        float px = selfPoint.x;
        float py = selfPoint.y;
        float pz = selfPoint.z;
        

        if (Mathf.Abs(px)>ax) 
        {
            if (px < 0)
            { transform.position = new Vector3(-ax, py, pz); }
            else
            { transform.position = new Vector3(ax, py, pz); }
        }
        if (Mathf.Abs(py) > ay) 
        {
            if (py < 0)
            { transform.position = new Vector3(px, -ay, pz); }
            else
            { transform.position = new Vector3(px, ay, pz); }
        }
        if (Mathf.Abs(pz) > az) 
        {
            if (pz < 0)
            { transform.position = new Vector3( px, py, -az); }
            else
            { transform.position = new Vector3( px, py, az); }
        }
    }
}
