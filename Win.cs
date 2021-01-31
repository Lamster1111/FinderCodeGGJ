using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject game;
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public AudioSource win;
    public AudioSource Bg;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }


        if (item1 == null && item2 == null && item3 == null)
        {
            win = GetComponent<AudioSource>();
            StartCoroutine(End());
            Bg.Stop();
            win.Play(0);
            Destroy(game);

        }




        
    }

    IEnumerator End()
    {
        yield return new WaitForSeconds(5);
        Application.Quit();


    }

}
