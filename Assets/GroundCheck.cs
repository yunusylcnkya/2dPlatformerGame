using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
     public static bool isGrounded=true;
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
         isGrounded= true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded = false;
    }
}
