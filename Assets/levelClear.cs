using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelClear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkMeyvekaldimi();
    }

    void checkMeyvekaldimi()
    {
        int sayi = gameObject.transform.childCount;
         Debug.Log(sayi);
    }
}
