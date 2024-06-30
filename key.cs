using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("playir"))
        {
       
            keysayac.key1 += 1;
            Destroy(gameObject);
            
        }


    }
}
