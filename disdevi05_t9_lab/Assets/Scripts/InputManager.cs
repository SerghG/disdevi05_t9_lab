using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerController motor;
    public WeaponController weapon;
    private PlayerInput playerInput;
    private PlayerInput.OnFootActions onFoot;
    private PlayerLook look;
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;
        
        motor = GetComponent<PlayerController>();
        weapon = GetComponent<WeaponController>();
        look = GetComponent<PlayerLook>();

        onFoot.Jump.performed += ctx => motor.Saltar();
        onFoot.Shoot.performed += ctx => weapon.Disparar();
    }

    void FixedUpdate()
    {
        motor.ProcessMove(onFoot.Movement.ReadValue<Vector2>());        
    }

    private void LateUpdate()
    {
        look.RealizarMirada(onFoot.Look.ReadValue<Vector2>());        
    }

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    private void OnEnable()
    {
        onFoot.Enable();
    }

    private void OnDisable()
    {
        onFoot.Disable();
    }
}
