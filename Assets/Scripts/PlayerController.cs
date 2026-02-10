using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float jumpHeight;

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
            _rb.linearVelocityY = jumpHeight;
            Debug.Log($"Jumping");
        }
    }
}
