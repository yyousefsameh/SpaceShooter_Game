using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector2 playerMovementVector;
    private new Rigidbody2D rigidbody2D;
    readonly float playerMovementSpeed = 1750f;
    float xDirection, yDirection;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        xDirection = Input.GetAxisRaw("Horizontal");
        yDirection = Input.GetAxisRaw("Vertical");
        playerMovementVector = playerMovementSpeed * Time.deltaTime * new Vector2(xDirection, yDirection);
        rigidbody2D.velocity = playerMovementVector;
    }
}
