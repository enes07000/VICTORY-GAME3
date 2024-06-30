using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HARDUSMAN : MonoBehaviour
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
        if (Vector2.Distance(transform.position, a.position) < .1f)
        {
            terget = b.position;
            gameObject.transform.localScale = new Vector3(3.09f, 3.035217f, 0);

        }
        if (Vector2.Distance(transform.position, b.position) < .1f)
        {
            terget = a.position;

            gameObject.transform.localScale = new Vector3(-3.09f, 3.035217f, 0);

        }
        transform.position = Vector2.MoveTowards(transform.position, terget, sped * Time.deltaTime);

    }
}
