using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MuaHoaQua : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject hoaQuaPrefab;
    public float thoiGianBanDan = 0.2f; // Điều chỉnh tần suất bắn đạn
    private float banDanTimer;
    private float timer;
    public int soLuongDan = 30;
    void Start()
    {
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.M))
        // {
        //     for (int i = 0; i < soLuongDan; i++)
        //     {
        //         banDanTimer -= Time.deltaTime;
        //         // Tạo một quả hoa quả ở vị trí ngẫu nhiên trên trục X
        //         Vector3 spawnPosition = new Vector3(Random.Range(-1f, 5f), 2.5f, 0f);
        //
        //         Instantiate(hoaQuaPrefab, spawnPosition, Quaternion.identity);
        //         banDanTimer = thoiGianBanDan;  
        //     }
        //      
        // }
            
            
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        
    }
}
