using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KONROL : MonoBehaviour
{
   public GameObject BLOCK2;
    public GameObject bottun2;
    public GameObject BLOCK3;
    public GameObject bottun3;
    void Start()
    {
        BLOCK2.SetActive(true);
        bottun2.SetActive(false);
        BLOCK3.SetActive(true);
        bottun3.SetActive(false);

        if (keysayac.key1 ==1)
        {

            BLOCK2.SetActive(false);
            bottun2.SetActive(true);

          
        }
        if (keysayac.key1 ==2 )
        {

            BLOCK2.SetActive(false);
            bottun2.SetActive(true);


            BLOCK3.SetActive(false);
            bottun3.SetActive(true);
        }
        if (keysayac.key1 == 3)
        {

            BLOCK2.SetActive(false);
            bottun2.SetActive(true);


            BLOCK3.SetActive(false);
            bottun3.SetActive(true);
        }
    }
    private void Update()
    {
       
    }

    // Update is called once per frame
    public void kon1()
    {
        SceneManager.LoadScene(2);

        heart.hort = 1;
        sayac.altin1 = 0;
        timt.StopTime = true;
    }
    public void kon2()
    {
        SceneManager.LoadScene(3);
        heart.hort = 1;
        sayac.altin1 = 0;
        timt.StopTime = true;
    }
    public void kon3()
    {
        SceneManager.LoadScene(4);
        heart.hort = 1;
        sayac.altin1 = 0;
        timt.StopTime = true;
    }
    public void levels()
    {
        SceneManager.LoadScene(1);
        timt.StopTime = true;
    }
   

    public void kazan2()
    {
        if (keysayac.key1 == 1)
        {

            
            SceneManager.LoadScene(3);


        }
        heart.hort = 1;
        sayac.altin1 = 0;
       
    }
    public void kazan3()
    {
        if (keysayac.key1 == 2)
        {

            
            SceneManager.LoadScene(4);


        }
        heart.hort = 1;
        sayac.altin1 = 0;
       
    }

   

}
