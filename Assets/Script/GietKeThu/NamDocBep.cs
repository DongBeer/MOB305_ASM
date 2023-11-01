using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamDocBep : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 ViTriChet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ViTriChet = transform.localPosition;
        //
        // if (Input.GetKeyDown(KeyCode.N))
        // {
        //     Destroy(gameObject);
        //     GameObject HinhBep = (GameObject)Instantiate(Resources.Load("Prefabs/VuNo"));
        //     HinhBep.transform.localPosition = ViTriChet;
        // }
    }
    
    private void OnCollisionEnter2D(Collision2D col)
    {
    
        if (col.collider.tag == "Player" && col.contacts[0].normal.y < 0)
        {
            Destroy(gameObject);
            GameObject HinhBep = (GameObject)Instantiate(Resources.Load("Prefabs/NamDocBep"));
            HinhBep.transform.localPosition = ViTriChet;
        }
    }
    
    
}
