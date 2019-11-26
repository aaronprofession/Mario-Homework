using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletionGameOver : MonoBehaviour
{
    public int deaths = 0;
    //Kills player upon touch and deletes killed Enemy prefabs
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag != "Player")
        {
            Destroy(other.gameObject);
        }
        else
        {
            Death();
        }
    }
    void Death()
    {
        deaths++;
    }
    void GameOverCheck()
    {

    }

}
