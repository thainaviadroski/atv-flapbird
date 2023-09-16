using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawPipe : MonoBehaviour
{
    // Start is called before the first frame update

    public float timeMax;
    private float time;
    public GameObject pipe;
    GameObject clonePipe;
    public float dist;

    void Start()
    {
        spawPipe();
    }

    // Update is called once per frame
    void Update()
    {

        if (time > timeMax  ) { 
            spawPipe();
            time = 0;
        }

        time += Time.deltaTime; 
    }

    void spawPipe()
    {
        clonePipe = Instantiate(pipe);
        clonePipe.transform.position = transform.position + new Vector3(0, Random.Range(dist, -dist), 0);
    }
}
