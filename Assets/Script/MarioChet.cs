using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioChet : MonoBehaviour
{
    // Start is called before the first frame update
    private float TocDoNay = 15f;
    private float DoNayCao = 100f;
    private Vector2 ViTriChet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(HMarioChet());
    }
    
    IEnumerator HMarioChet()
    {
        
        while (true)
        {
            transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y + TocDoNay*Time.deltaTime);
            if (transform.localPosition.y >= ViTriChet.y + DoNayCao + 1)
            {
                break;
            }

            yield return null;
            transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y - TocDoNay*Time.deltaTime);
            if (transform.localPosition.y <= -10f)
            {
                Destroy(gameObject);
                break;
            }
            yield return null;
        }
    }
}
