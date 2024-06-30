using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duvar : MonoBehaviour
{
    public Transform a, b;
    public float sped = 5;
    Vector2 terget;
   
    void Start()
    {
        terget = b.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, a.position) < .1f) terget = b.position;
        if (Vector2.Distance(transform.position, b.position) < .1f) terget = a.position;
        transform.position = Vector2.MoveTowards(transform.position, terget, sped * Time.deltaTime);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("playir"))
        {
            collision.transform.SetParent(this.transform);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("playir"))
        {
            collision.transform.SetParent(null);
        }
    }
}
