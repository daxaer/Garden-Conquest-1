using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private float jumpForce = 300;

    InputController inputActions;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private int miTurno;
    [SerializeField] private Animator animator;
    SpriteRenderer sprite;
    [SerializeField] private ContactFilter2D groundFilter;
    bool muerto = false;

    private void Awake()
    {
        inputActions = new InputController();
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
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
        inputActions.Gameplay.Derecha.canceled += _ => DerechaCanceled();
        inputActions.Gameplay.Izquierda.canceled += _ => IzquierdaCanceled();
    }

    private void IzquierdaCanceled()
    {
        animator.SetBool("run", false);
    }

    private void DerechaCanceled()
    {
        animator.SetBool("run", false);
    }

    private void Update()
    {

    }
    private void FixedUpdate()
    {
        if(GameManager.Instance.GetApuntando() == false && GameManager.Instance.GetTurn() == miTurno && muerto == false)
        {
            rb.position += Axis.normalized * 15f * Time.fixedDeltaTime;
        }
    }
    void Jump()
    {
        if (GameManager.Instance.GetApuntando() == false && GameManager.Instance.GetTurn() == miTurno && tocandoPiso == true && muerto == false)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    void Derecha()
    {
        animator.SetBool("run", true);
        if (GameManager.Instance.GetApuntando() == false && GameManager.Instance.GetTurn() == miTurno && muerto == false)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
    void Izquierda()
    {
        animator.SetBool("run", true);
        if (GameManager.Instance.GetApuntando() == false && GameManager.Instance.GetTurn() == miTurno && muerto == false)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }

    public void Muerto()
    {
        muerto = true;
        animator.SetBool("muerto", true);
    }
    Vector2 Axis => inputActions.Gameplay.Axis.ReadValue<Vector2>();

    bool tocandoPiso => rb.IsTouching(groundFilter);

    public Transform SetObjetivos()
    {
        return transform;
    }
}