using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VatDiChuyenDuoc : MonoBehaviour
{
    // Start is called before the first frame update
    public float VanTocVat;
    public bool DiChuyenTrai = true;
    
    // public float top, bot;
    // public bool isCheck;
    
    // public float thoiGianBanDan = 0.2f; // Điều chỉnh tần suất bắn đạn
    // private float banDanTimer;

    void Start()
    {
        DiChuyenTrai = true;
    }

    private void FixedUpdate()
    {
        Vector2 DiChuyen = transform.localPosition;
        if (DiChuyenTrai == true)
        {
            DiChuyen.x -= VanTocVat * Time.deltaTime;
        }
        else
        {
            DiChuyen.x += VanTocVat * Time.deltaTime;
        }
        
        transform.localPosition = DiChuyen;

        
        // banDanTimer -= Time.deltaTime;
        // if (banDanTimer <= 0)
        // {
        //     Instantiate(skill, transform.position, Quaternion.identity);
        //     DanController dan = this.skill.GetComponent<DanController>();
        //     dan.direction = Vector3.up;
        //     banDanTimer = thoiGianBanDan;
        // }
        
            
            
        
        
    }

    

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag != "Player" && col.contacts[0].normal.x > 0)
        {
            DiChuyenTrai = true;
            QuayMat();
        }
        else if(col.collider.tag != "Player" && col.contacts[0].normal.x < 0)
        {
            DiChuyenTrai = false;
            QuayMat();
        }
        // Ban();
    }
    
    void QuayMat()
    {
        DiChuyenTrai = !DiChuyenTrai;
        Vector2 HuongQuay = transform.localScale;
        HuongQuay.x *= -1;
        transform.localScale = HuongQuay;
    }

}
