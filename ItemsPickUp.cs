using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsPickUp : MonoBehaviour
{
    private SpriteRenderer sprite;
    public AudioSource Tada;
    private BoxCollider2D box;
    void OnCollisionEnter2D(Collision2D col)
    {
        
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (col.gameObject.tag == "Player")
        {
            if (col.transform.childCount < 2) {
                Tada = GetComponent<AudioSource>();
                sprite = GetComponent<SpriteRenderer>();
                box = GetComponent<BoxCollider2D>();
                Tada.Play(0);
                transform.SetParent(col.transform, true);
                sprite.sortingOrder = 5;
                transform.localPosition = new Vector3(3.5f, 1.5f, 0);
                Destroy(box);
            }
            
        }
       

    }
}
