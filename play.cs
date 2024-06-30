using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor;
//using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UI;
public class play : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    private float movee;
    public float seed = 8f;
    public float jump;
    private bool isjamping;

    public GameObject slmon;
    public GameObject gameovver;


    public GameObject winer;

    public Animator walik;
    public Animator jump1;
    public Animator day;
    public AudioSource jumpsond;
    public AudioSource  winersond;
    public AudioSource GOMEOVERSES;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void Update()
    {
        movee = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(movee * seed, rb.velocity.y);
        if (movee > 0)
        {
            gameObject.transform.localScale = new Vector3(0.1983809F, 0.1286655F, 0);
            walik.SetBool("idel", true);
        }
        else if (movee < 0)
        {
            gameObject.transform.localScale = new Vector3(-0.1983809F, 0.1286655F, 0);
            walik.SetBool("idel", true);
        }
        else if (movee == 0)
        {
            walik.SetBool("idel", false);
        }


        if (Input.GetButtonDown("Jump") && !isjamping)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            isjamping = true;
            jump1.SetBool("Jump", true);
            jumpsond.Play();
        }

    }
    void OnCollisionEnter2D(Collision2D ohter)
    {
        if (ohter.gameObject.CompareTag("ground"))
        {
            isjamping = false;
            jump1.SetBool("Jump", false);

        }

        if (ohter.gameObject.CompareTag("enemy"))
        {
            heart.hort -= 1;
            gameObject.SetActive(false);
            day.SetBool("day", true);

            gameObject.transform.position = new Vector3(-6.6594f, -2.558f, 0);
            day.SetBool("day", false);
            gameObject.SetActive(true);


            if (heart.hort == 0)
            {
                timt.StopTime = false;
                day.SetBool("day", true);
                gameObject.SetActive(false);
                Instantiate(slmon, transform.position, Quaternion.identity);
                Instantiate(gameovver, transform.position, Quaternion.identity);
                GOMEOVERSES.Play();
}

        }

        if (ohter.gameObject.CompareTag("kare"))
        {
            winersond.Play();
            timt.StopTime = false;
            gameObject.SetActive(false);
           Instantiate(winer, transform.position, Quaternion.identity);
        }
    }
}
