using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement3 : MonoBehaviour
{
    public float speed = 10;
    private float hori;
    private float verti;

    // Start is called before the first frame update
    void Start()
    {





    }

    // Update is called once per frame
    void Update()
    {
        verti = Input.GetAxis("Vertical");
        hori = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.up * Time.deltaTime * speed * verti);
        transform.Translate(Vector3.right * Time.deltaTime * speed * hori);
        if (hori > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;

        }
        if (hori < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;

        }


    }
}
