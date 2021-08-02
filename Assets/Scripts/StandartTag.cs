using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandartTag : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "changeWall")
        {
            transform.gameObject.tag = "Player";
            Destroy(collision.gameObject);
        }
    }
}
