using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KhoiChuaVatPham : MonoBehaviour
{
    // Start is called before the first frame update

    public float DoNayCuaKhoi = 0.5f;
    public float TocDoNay = 4f;
    public bool DuocNay = true;

    private Vector2 ViTriLucDau;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "VaCham" && col.contacts[0].normal.y > 0)
        {

            ViTriLucDau = transform.position;
            KhoiNayLen();
            
        }
        
    }

    void KhoiNayLen()
    {
        if (DuocNay)
        {
            
            StartCoroutine(KhoiNay());
            DuocNay = false;
        }
    }

    IEnumerator KhoiNay()
    {
        while (true)
        {
            transform.localPosition = new Vector2(transform.localPosition.x,
                transform.localPosition.y + TocDoNay * Time.deltaTime);
            if (transform.localPosition.y >= ViTriLucDau.y + DoNayCuaKhoi)
            {
                break;
            }

            yield return null;
        }

        while (true)
        {
            transform.localPosition = new Vector2(transform.localPosition.x,
                transform.localPosition.y - TocDoNay * Time.deltaTime);
            if (transform.localPosition.y <=  ViTriLucDau.y)
            {
                break;
            }
            
            Destroy(gameObject);
            GameObject KhoiRong = (GameObject)Instantiate(Resources.Load("Prefabs/KhoiTrong"));
            KhoiRong.transform.position = ViTriLucDau;
            yield return null;
        }
    }
}
