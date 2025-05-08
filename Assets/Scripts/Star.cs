using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public AudioClip coinSound;
    public void cambio()
    {
      float segundo = 0.0f;
      

     }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        
        if (collision.collider)
        {
            AudioManager.instance.PlayAudio(coinSound, "coindSound", false, 0.3f);
           
            Destroy(gameObject);
        }

    }


}
