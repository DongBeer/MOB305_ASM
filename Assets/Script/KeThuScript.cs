using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class KeThuScript : MonoBehaviour
{
    // Start is called before the first frame update
     GameObject MarioNho;
     

    private void Awake()
    {
        MarioNho = GameObject.FindGameObjectWithTag("Player");
    }
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Player" && (col.contacts[0].normal.x > 0 || col.contacts[0].normal.x < 0))
        {
            if (MarioNho.GetComponent<MarioControler>().CapDo > 1)
            {
                MarioNho.GetComponent<MarioControler>().CapDo = 1;
                MarioNho.GetComponent<MarioControler>().BienHinh = true;
            }
            else
            {
                MarioNho.GetComponent<MarioControler>().MarioChet();
                StartCoroutine(RestartAfterDelay(4f));
            }
        }
        
    }
    
     IEnumerator RestartAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}
