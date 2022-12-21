using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sidestep : MonoBehaviour
{
    public GameObject pos1;
    public GameObject pos2;

    public GameObject wayp;
    public int l;
    public float speed =2;
    Vector3 startPos;
    waypoint_setup br;

    public List<GameObject> b;
    // Start is called before the first frame update
    void Start()
    {
        b.Add(pos1);
        b.Add(pos2);
        l=0;
        startPos = transform.position;
        br = wayp.GetComponent<waypoint_setup>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 curtar = br.waypoints[l];
        // Vector3 totar = curtar - transform.position;

        // gameObject.transform.position= Vector3.MoveTowards(transform.position, curtar, speed* Time.deltaTime);
        
        // //gameObject.transform.position = startPos + (Vector3.up * Mathf.Sin(Time.time * 2)*.2f);
        // if (Vector3.Distance(transform.position,  curtar) < .5f)
        // {
        //     l=(l +1) % br.waypoints.Count;
            
        // }
        
        // Quaternion q = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(totar), 1.5f * Time.deltaTime);
        // transform.rotation = q;

        transform.position += transform.forward * Time.deltaTime;
    }

    void FixedUpdate()
    {
        
    }
}
