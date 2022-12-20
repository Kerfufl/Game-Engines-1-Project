using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sidestep : MonoBehaviour
{
    public GameObject pos1;
    public GameObject pos2;

    public int l;

    public List<GameObject> b;
    // Start is called before the first frame update
    void Start()
    {
        b.Add(pos1);
        b.Add(pos2);
        l=0;
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void FixedUpdate()
    {
        transform.position= Vector3.Lerp(transform.position, b[l].transform.position, .01f);

        if (transform.position == b[l].transform.position)
        {
            l+=1;
            l %= 2;
        }
    }
}
