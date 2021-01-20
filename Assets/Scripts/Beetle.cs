using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beetle : MonoBehaviour
{
    public float speed = 4f;
    bool isHidden = false;
    bool isWait = false;
    public float waitTime = 4f;
    public Transform point;

    // Start is called before the first frame update
    void Start()
    {
        point.transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
       if (!isWait)
       {
            transform.position = Vector3.MoveTowards
            (transform.position, 
            point.position, speed * Time.deltaTime);

       }
    }
}
