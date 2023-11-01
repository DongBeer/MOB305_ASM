using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamController : MonoBehaviour
{
    
    public float right, left;
    public bool isCheck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var Namx = transform.position.x;
        if (Namx < left)
        {
            isCheck = true;
        }

        if (Namx > right)
        {
            isCheck = false;
        }

        if (isCheck)
        {
            transform.Translate(new Vector3(Time.deltaTime * 1, 0, 0));
        }
        else
        {
            transform.Translate(new Vector3(-Time.deltaTime * 1, 0, 0));
        }
    }
}
