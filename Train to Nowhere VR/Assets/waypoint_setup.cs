using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypoint_setup : MonoBehaviour
{
    public List<Vector3> waypoints;
    public int count = 5;
    public float radius = 5;

    void SetUpWaypoints()
    {
        waypoints = new List<Vector3>();
        waypoints.Clear();
        float theta = (Mathf.PI * 2.0f) / (float) count;

        for(int i = 0 ; i < count ; i ++)
        {
            float angle = i * theta;
            Vector3 p = new Vector3
                (
                    Mathf.Sin(angle) * radius, 
                    0,
                    Mathf.Cos(angle) * radius
                );
            p = transform.TransformPoint(p);
            waypoints.Add(p);

        }
    }

    void OnDrawGizmos()
    {
        if (!Application.isPlaying)
        {
            SetUpWaypoints();
            foreach (Vector3 v in waypoints)
            {
                Gizmos.DrawWireSphere(v, 0.5f);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        SetUpWaypoints();
    }

    int current = 0;
    // Update is called once per frame
    void Update()
    {
        
    }
}
