using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed = 8f;
    public float JumpForce = 15f;
    private Rigidbody2D _playerRb;
    public LayerMask WhatIsGround;
    private CapsuleCollider2D _playerCollider;
    // Start is called before the first frame update
    void Start()
    {
        _playerRb = GetComponent<Rigidbody2D>();
        _playerCollider = GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Run()
    {
       float _horizontalInput = Input.GetAxis("Horizontal");

       _playerRb.velocity = new Vector2(_horizontalInput * MoveSpeed, _playerRb.velocity.y);

       if(Mathf.Abs(_horizontalInput) > 0)
       {
           _playerAnim.SetFloat("Speed", Mathf.Abs(_horizontalInput));
       }
       else
       {
           _playerAnim.SetFloat("Speed", 0);
       }
    }

    void Jump()
    {
        if (_playerCollider.IsTouchingLayers(WhatIsGround)) //_playerCollider.IsTouchingLayers(LayerMask.GetMask("Ground"))
        {
            _isOnGround = true;
            _canDoubleJump = true;
            _playerAnim.SetBool("IsOnGround", _isOnGround);
        }
        else
        {
            _isOnGround = false;
            _playerAnim.SetBool("IsOnGround", _isOnGround);
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (_isOnGround)
            {
                _playerRb.velocity = new Vector2(_playerRb.velocity.x, JumpForce);
            }
            else
            {
                if (_canDoubleJump)
                {
                    _playerRb.velocity = new Vector2(_playerRb.velocity.x, JumpForce);
                    _playerAnim.SetTrigger("DoubleJump");
                    _canDoubleJump = false;
                }
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
