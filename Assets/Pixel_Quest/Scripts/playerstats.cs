using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerstats : MonoBehaviour
{
    public Transform respawnPoint;
    public string nextlevel = "scene_2";
    public int CoinCounter = 0;
    private int _Health = 3;
    private int _maxhealth = 3;
    private void OnTriggerEnter2D(Collider2D collision) { 
        Debug.Log("hit");
        switch (collision.tag)
        {
            case "Death":
                {
                    _Health--;
                    if (_Health <= 0) {
                        string thislevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thislevel);
                    }
                    else
                    {
                        transform.position = respawnPoint.position;
                    }
                        
                    
                    break;
                }
                
            case "Finish":
                {
                    string nextlevel = collision.transform.GetComponent<levelgoal>().nextlevel;
                    SceneManager.LoadScene(nextlevel);
                    break;
                }

            case "Coin":
                CoinCounter++;
                Destroy(collision.gameObject);
                break;

            case "Health":
                {
                    Destroy(collision.gameObject);
                    _Health++;
                    break;

                }
        }
    } 
}
