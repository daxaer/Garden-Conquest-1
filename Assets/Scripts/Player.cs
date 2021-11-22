using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField, Range(1f, 10f)] float jumpForce = 5f;

    InputController inputActions;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private int miTurno;

    private void Awake()
    {
        inputActions = new InputController();
    }
    private void OnEnable()
    {
        inputActions.Enable();
    }
    private void OnDisable()
    {
        inputActions.Disable();
    }
    private void Start()
    {
        inputActions.Gameplay.Jump.performed += _ => Jump();
        inputActions.Gameplay.Derecha.performed += _ => Derecha();
        inputActions.Gameplay.Izquierda.performed += _ => Izquierda();
    }
    private void Update()
    {
        if(GameManager.Instance.GetApuntando() == false && GameManager.Instance.GetTurn() == miTurno)
        {
            transform.Translate(Axis * 5F * Time.deltaTime);
        }
    }
    void Jump()
    {
        if (GameManager.Instance.GetApuntando() == false && GameManager.Instance.GetTurn() == miTurno)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    void Derecha()
    {
        if (GameManager.Instance.GetApuntando() == false && GameManager.Instance.GetTurn() == miTurno)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
    void Izquierda()
    {
        if (GameManager.Instance.GetApuntando() == false && GameManager.Instance.GetTurn() == miTurno)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }
    Vector2 Axis => inputActions.Gameplay.Axis.ReadValue<Vector2>();
}