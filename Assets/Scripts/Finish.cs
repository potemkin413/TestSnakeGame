using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "FINISH")
        {

            SceneManager.LoadScene(0);
        }

    }
}
