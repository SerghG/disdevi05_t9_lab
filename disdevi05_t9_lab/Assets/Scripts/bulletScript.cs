using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
   
    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(""+collision.collider.tag);
        if(collision.collider.CompareTag("Suelo") || collision.collider.CompareTag("Pared")){
            Destroy(this.gameObject);
            Debug.Log("Colision Suelo o Pared");
        } 
        if(collision.collider.CompareTag("Enemy")){
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            GameObject.Find("GameController").GetComponent<GameController>().AddScore(20);
            GameObject.Find("AudioPlayer").GetComponent<AudioController>().PlaySFX(GameObject.Find("AudioPlayer").GetComponent<AudioController>().SFXClips[1]);
            Debug.Log("Colision Enemigo");
        }
        if(collision.collider.CompareTag("Civil")){
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            GameObject.Find("GameController").GetComponent<GameController>().AddScore(-20);
            GameObject.Find("AudioPlayer").GetComponent<AudioController>().PlaySFX(GameObject.Find("AudioPlayer").GetComponent<AudioController>().SFXClips[1]);
            Debug.Log("Colision civil");
        }
    }
}
