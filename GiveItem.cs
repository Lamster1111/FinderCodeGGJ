using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveItem : MonoBehaviour
{
    public GameObject Item;
    public GameObject WIW;
    void OnCollisionEnter2D(Collision2D col)
    {

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (col.gameObject.tag == "Player")
        {

            //Check to see if the Item as a parent
            if (Item.transform.parent != null)
            {
                Destroy(Item);
                Destroy(WIW);
            }
        }


    }
}
