using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pipeMove();
    }   

    void pipeMove()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
