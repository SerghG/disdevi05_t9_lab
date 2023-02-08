using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera camara;
    public float sensibilidadX = 30f;
    public float sensibilidadY = 30f;

    private float xRotation = 0f;

    public void RealizarMirada(Vector2 input){
        float mouseX = input.x;
        float mouseY = input.y;

        xRotation -= (mouseY * Time.deltaTime) * sensibilidadY;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        camara.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime)*sensibilidadX);
    }
}
