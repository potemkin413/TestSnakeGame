using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class diamondBoost : MonoBehaviour
{
    private diamManager dm;



    private void Start()
    {
        dm = FindObjectOfType<diamManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
     dm.ScorePlus();
     Destroy(gameObject);

    }
}
