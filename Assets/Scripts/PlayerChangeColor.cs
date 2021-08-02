
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class PlayerChangeColor : MonoBehaviour
{
    private PlayerScore ps;

    void Start()
    {
        ps = FindObjectOfType<PlayerScore>();

    }

    public void IndexZero()
    {
        GetComponent<Collider>().gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
        transform.gameObject.tag = "upPurple";
        Debug.Log("Change" + transform.gameObject.tag);
    }
    public void IndexOne()
    {
        GetComponent<Collider>().gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
        transform.gameObject.tag = "upYellow";
        Debug.Log("Change" + transform.gameObject.tag);
    }
    public void IndexTwo()
    {
        GetComponent<Collider>().gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        transform.gameObject.tag = "upRed";
        Debug.Log("Change" + transform.gameObject.tag);
    }
    public void IndexThree()
    {
        GetComponent<Collider>().gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        transform.gameObject.tag = "upGreen";
        Debug.Log("Change" + transform.gameObject.tag);
    }
    public void IndexFour()
    {
        GetComponent<Collider>().gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        transform.gameObject.tag = "upGreen";
        Debug.Log("Change" + transform.gameObject.tag);
    }


    public int IndexRandom()
    {
        int index = Random.Range(0, 5);
        return index;
    }
    void OnCollisionEnter(Collision collision)
    {
        
        if (transform.gameObject.tag == "Player" || collision.transform.gameObject.tag == "changeWall")
        {
            
            
            if (ps.Result() == 4 )
            {
                IndexFour();
            }
            if (ps.Result() == 1 )
            {
                IndexOne();
            }
            if (ps.Result() == 2 )
            {
                IndexTwo();
            }
            if (ps.Result() == 3 )
            {
                IndexThree();
            }
            if (ps.Result() == 0 )
            {
                IndexZero();
            }
        }
        
    }
}

