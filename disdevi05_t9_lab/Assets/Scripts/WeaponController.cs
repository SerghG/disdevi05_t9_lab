using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public float velocidadDisparo = 600f;
    public int municion = 6;
    public GameObject bulletPrefab;
    public GameObject bulletPoint;
    public GameObject AudioController;

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    private void Update()
    {
        
    }

    public void Disparar(){
        if(municion > 0){
            GameObject bullet = Instantiate(bulletPrefab, bulletPoint.transform.position, transform.rotation);
            AudioController.GetComponent<AudioController>().PlaySFX(AudioController.GetComponent<AudioController>().SFXClips[0]);
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * velocidadDisparo);
            municion--;
            Debug.Log("Munición restante:" + municion);
        }
    }
}
