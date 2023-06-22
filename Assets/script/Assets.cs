using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assets : MonoBehaviour
{
    public string floorTag = "floor";
   
    private bool hasWon = false;
   
        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag(floorTag))
            {
            Win();
            }

        else if (collision.gameObject.CompareTag(floorTag))
        {

            Destroy(collision.gameObject);
        }
    }


        
    

    private void Win()
    {
        if (!hasWon)
        {

            hasWon = true;
            Debug.Log("You win!");
           
        }
    }
}