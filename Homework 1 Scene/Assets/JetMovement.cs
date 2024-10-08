using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class JetMovement : MonoBehaviour
{
    [SerializeField] float boostModifier = 5f;
    Rigidbody2D rb;
    Vector2 inputDirection = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OnMove(InputValue value)
    {
        Vector2 movementDir = value.Get<Vector2>();
        inputDirection = movementDir;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(inputDirection * boostModifier);
    }


}
