using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door3 : MonoBehaviour
{
    public GameObject door1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (keysayac.key1 == 3)
        {
            gameObject.SetActive(false);
            Instantiate(door1, transform.position, Quaternion.identity);
        }

    }
}
