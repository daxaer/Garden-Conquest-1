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
    [SerializeField] private SpriteRenderer[] sprite;
    [SerializeField] private Transform pie;
    bool TocandoPiso;

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
        TocandoPiso = Physics2D.OverlapCircle(pie.position, 1f, 1 << 6);
    }
    private void FixedUpdate()
    {
        if(GameManager.Instance.GetApuntando() == false && GameManager.Instance.GetTurn() == miTurno)
        {
            rb.(rb.position + Axis.normalized * 10f * Time.fixedDeltaTime);
        }
    }
    void Jump()
    {
        if (GameManager.Instance.GetApuntando() == false && GameManager.Instance.GetTurn() == miTurno && TocandoPiso == true)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    void Derecha()
    {
        if (GameManager.Instance.GetApuntando() == false && GameManager.Instance.GetTurn() == miTurno)
        {
           for(int i = 0;i < sprite.Length; i++)
           {
                sprite[i].flipX = false;
           }
        }
    }
    void Izquierda()
    {
        if (GameManager.Instance.GetApuntando() == false && GameManager.Instance.GetTurn() == miTurno)
        {
            for (int i = 0; i < sprite.Length; i++)
            {
                sprite[i].flipX = true;
            }
        }
    }
    Vector2 Axis => inputActions.Gameplay.Axis.ReadValue<Vector2>();

}