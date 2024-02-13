using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Collect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {   if (collision.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;

            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Invoke("yoket",0.4f);
        }

       
    }

    void yoket()
    {
        Destroy(gameObject);
    }

}
