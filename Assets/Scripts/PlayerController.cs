using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float jumpForce;
    public Animator animator;
    public GameObject collectSound;

    private Rigidbody2D _rb;
    private InputAction _jump;
    private int _diamondsCollected;
    private float _jumpSoundTimer = 0;

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
        _jumpSoundTimer -= Time.deltaTime;
        
        if (_jump.IsPressed())
        {
            _rb.linearVelocityY = jumpForce;
            animator.SetBool("IsJump", true);

            if (_jumpSoundTimer <= 0)
            {
                GetComponent<AudioSource>().Play();
                _jumpSoundTimer = 0.25f;
            }
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
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Diamond"))
        {
            _diamondsCollected++;
            collectSound.GetComponent<AudioSource>().Play();
        }
    }

    public int GetDiamondCount()
    {
        return _diamondsCollected;
    }
}
