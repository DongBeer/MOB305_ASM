using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSceen : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform Player;
    private float minX = 0, maxX = 85;
    void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {
            Vector3 vitri = transform.position;
            vitri.x = Player.position.x;
            if (vitri.x < minX)
            {
                vitri.x = 0;
            }

            if (vitri.x > maxX)
            {
                vitri.x = maxX;
                
            }
            transform.position = vitri;
        }
    }
}
