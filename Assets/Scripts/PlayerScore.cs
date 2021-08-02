using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.SceneManagement;

public class PlayerScore : MonoBehaviour
{
    private PlayerChangeColor pc;
    private Rigidbody rb;
    private float speed;
    public int scoreDiamonds = 0;
    public float newSpeed;
    public float timer = 5f;
    public string prewTag;
    public int IndexForTag;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = -5f;
        newSpeed = -15f;
        pc = FindObjectOfType<PlayerChangeColor>();
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "diamond")
        {
            scoreDiamonds++;
        }
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
            Debug.Log("collision detected");
        }

        if (collision.gameObject.tag == "dead" && gameObject.tag != "GOD")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (gameObject.tag == "GOD")
        {
            if (collision.gameObject.tag != "FLOR")
            {
                Destroy(collision.gameObject);
            }
        }

    }

    public float Result()
    {
        IndexForTag = pc.IndexRandom();
        return IndexForTag;
    }

    void Update()
    {
        
        if (scoreDiamonds >= 5)
        {
            rb.velocity = new Vector3(newSpeed, 0f, 0f);
            if (timer > 0)
            {
                transform.gameObject.tag = "GOD";
                timer -= Time.deltaTime;
                Debug.Log(scoreDiamonds);
            }
            if (timer <= 0)
            {
                scoreDiamonds = 0;
                timer = 5f;
                if (IndexForTag == 0)
                {
                    scoreDiamonds = 0;
                    pc.IndexZero();
                    rb.velocity = new Vector3(speed, 0f, 0f);
                }
                if (IndexForTag == 1)
                {
                    scoreDiamonds = 0;
                    pc.IndexOne();
                    rb.velocity = new Vector3(speed, 0f, 0f);
                }
                if (IndexForTag == 2)
                {
                    scoreDiamonds = 0;
                    pc.IndexTwo();
                    rb.velocity = new Vector3(speed, 0f, 0f);
                }
                if (IndexForTag == 3)
                {
                    scoreDiamonds = 0;
                    pc.IndexThree();
                    rb.velocity = new Vector3(speed, 0f, 0f);
                }
                if (IndexForTag == 4)
                {
                    scoreDiamonds = 0;
                    pc.IndexFour();
                    rb.velocity = new Vector3(speed, 0f, 0f);
                }
            }  
        }
        else
        {
            if (IndexForTag == 0)
            {
                pc.IndexZero();
                rb.velocity = new Vector3(speed, 0f, 0f);
            }
            if (IndexForTag == 1)
            {
                pc.IndexOne();
                rb.velocity = new Vector3(speed, 0f, 0f);
            }
            if (IndexForTag == 2)
            {
                pc.IndexTwo();
                rb.velocity = new Vector3(speed, 0f, 0f);
            }
            if (IndexForTag == 3)
            {
                pc.IndexThree();
                rb.velocity = new Vector3(speed, 0f, 0f);
            }
            if (IndexForTag == 4)
            {
                pc.IndexFour();
                rb.velocity = new Vector3(speed, 0f, 0f);
            }

        }
        
    }
}
