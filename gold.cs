using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gold : MonoBehaviour
{
    public AudioSource sounde;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("playir"))
        {
            sounde.Play();
            sayac.altin1 += 1;
            Destroy(gameObject);
            if (sayac.altin1 == 10)
            {
                sayac.altin1 = 0;
                heart.hort += 1;
            }
        }


    }
}
