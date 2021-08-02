using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class diamManager : MonoBehaviour
{
    public int scoreDiam;
    public Text scoreDiamonds;

    private void Update()
    {
        scoreDiamonds.text = "Алмазы: " + scoreDiam.ToString();
    }

    public void ScorePlus()
    {
        scoreDiam++;
    }
    public void DeadScore()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
