using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class hareketliTuzak : MonoBehaviour
{
    [SerializeField] List<Transform> points= new List<Transform>();
    void Start()
    {
       
    }

    
    void Update()
    {
        
    }

    void hareket()
    {

        transform.Translate(points[0].position);
    }
}
