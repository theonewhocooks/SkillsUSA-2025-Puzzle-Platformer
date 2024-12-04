using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2: MonoBehaviour
{
    public float MoveSpeed = 8f;
    public float JumpForce = 15f;
    private Rigidbody2D _playerRb;
    public LayerMask WhatIsGround;
    [SerializeField] private bool _isOnGround;
    private CapsuleCollider2D _playerCollider;


    void Start()
    {
        _playerRb = GetComponent<Rigidbody2D>();
        _playerCollider = GetComponent<CapsuleCollider2D>();
    }

    void Update()
    {
        Run();
        Jump();
        FlipSprite();
    }

    void Run()
    {
  	    if (Input.GetKey(KeyCode.LeftArrow))
	    {
		transform.position += Vector3.left * MoveSpeed * Time.deltaTime;
	    }
	    if (Input.GetKey(KeyCode.RightArrow))
	    {
		transform.position += Vector3.right * MoveSpeed * Time.deltaTime;
	    }

    }

    void Jump()
    {
        if (_playerCollider.IsTouchingLayers(WhatIsGround))
        {
            _isOnGround = true;
        }
        else
        {
            _isOnGround = false;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (_isOnGround)
            {
                _playerRb.velocity = new Vector2(_playerRb.velocity.x, JumpForce);
            }
        }
    }

    void FlipSprite()
    {
        bool _playerHasHorizontalSpeed = Mathf.Abs(_playerRb.velocity.x) > Mathf.Epsilon;

        if(_playerHasHorizontalSpeed)
        {
            transform.localScale = new Vector2(Mathf.Sign(_playerRb.velocity.x), 1f);
        }
    }
    
    public void BouncePlayer(float bounceForce)
    {
        _playerRb.velocity = new Vector2(_playerRb.velocity.x, bounceForce);
    }

}
