using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float jumpForce;
    public Animator animator;

    private Rigidbody2D _rb;
    private InputAction _jump;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _jump = GetComponent<PlayerInput>().actions.FindAction("Jump");
    }

    private void FixedUpdate()
    {
        CheckForJump();
    }

    private void CheckForJump()
    {
        if (_jump.IsPressed())
        {
            _rb.linearVelocityY = jumpForce;
            animator.SetBool("IsJump", true);
        }
        else
        {
            animator.SetBool("IsJump", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Game Over!");
        }
    }
}
