using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bonus : MonoBehaviour
{
    private ScoreManager sm;

    private void Start()
    {
        sm = FindObjectOfType<ScoreManager>();
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == gameObject.tag)
        {
            sm.Kill();
            Destroy(gameObject);
        }
        if (collision.gameObject.tag != gameObject.tag && collision.gameObject.tag != "GOD")
        {
            sm.UnKill();
            Destroy(gameObject);
        }
    }
}
