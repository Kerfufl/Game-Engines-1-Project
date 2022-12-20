using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest : MonoBehaviour
{
    private float playerSpeed = .5f;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(new Vector3(playerSpeed * Time.deltaTime,0,0 ));
        gameObject.transform.position = gameObject.transform.position + (new Vector3(0,Mathf.Sin(Time.time),0)*.02f);
    }
}
