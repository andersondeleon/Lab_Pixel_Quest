using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerstats : MonoBehaviour
{
    public string nextlevel = "scene_2";
    private void OnTriggerEnter2D(Collider2D collision) { 
        Debug.Log("hit");
        switch (collision.tag)
        {
            case "Death":
                {
                    string thislevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextlevel);
                    break;
                }


        }
    }
}
