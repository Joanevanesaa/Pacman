using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pellet : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D coll)
    {
        if(coll.gameObject.tag.Equals("PacMan"))
        {
            Destroy(gameObject);

        }
    }

}
