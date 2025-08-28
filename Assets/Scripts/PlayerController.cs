using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    float horizontalInput;
    public float speed = 2f;

    [SerializeField] private Rigidbody2D _playerRb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    public void PlayerMovement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        _playerRb.linearVelocityX = horizontalInput * speed;
    }
}
