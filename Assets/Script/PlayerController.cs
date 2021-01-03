using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{

    public Rigidbody2D PlayerRigidbody2D;
    public float MovementSpeed;

    public Animator PlayerAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerRigidbody2D.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * MovementSpeed;

        PlayerAnimator.SetFloat("moveX", PlayerRigidbody2D.velocity.x);
        PlayerAnimator.SetFloat("moveY", PlayerRigidbody2D.velocity.y);

        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            PlayerAnimator.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
            PlayerAnimator.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
        }
    }
}
