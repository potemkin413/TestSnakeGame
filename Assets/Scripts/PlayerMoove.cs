using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMoove : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = -5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.velocity = new Vector3(speed, 0f, 0f);
    }
}
