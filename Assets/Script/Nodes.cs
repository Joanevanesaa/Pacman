using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodes : MonoBehaviour
{
    public Nodes[] Surrounding;
    public Vector2[] validDirection;

    // Start is called before the first frame update
    void Start()
    {
        validDirection = new Vector2[Surrounding.Length];
        for(int i = 0; i < Surrounding.Length; i++)
        {
            Nodes neighbour = Surrounding[i];
            Vector2 tempVector = neighbour.transform.localPosition - transform.localPosition;

            validDirection[i] = tempVector.normalized;
        }
    }

}
