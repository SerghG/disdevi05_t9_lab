using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 velocidadJugador;
    private bool isGrounded;

    public float gravity = -9.8f;
    public float vel = 5f;
    public float jumpHeigth = 3f;

    public float cadenciaDisparo = 0.1f;
    public float municion = 6;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = controller.isGrounded;
    }

    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        controller.Move(transform.TransformDirection(moveDirection)* vel *Time.deltaTime);
        velocidadJugador.y += gravity * Time.deltaTime;
        if(isGrounded && velocidadJugador.y < 0)
        {
            velocidadJugador.y = -2f;
        }
        controller.Move(velocidadJugador * Time.deltaTime);
    }

    public void Saltar()
    {
        if(isGrounded)
        {
            velocidadJugador.y = Mathf.Sqrt(jumpHeigth * -3.0f * gravity);
        }
    }

    public void Disparar(){
        if(municion > 0){
            municion--;
        }
    }
}
