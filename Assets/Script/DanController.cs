using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanController : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 direction = Vector3.up;

    public float speed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction*speed*Time.deltaTime);
    }
}
