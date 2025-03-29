using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [Header("Player Settings")]
    [SerializeField] private float moveSpeed;
    private Rigidbody2D rb;
    private float xInput;
    private Animator anim;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        Animations();
        HandleMovement();
    }

    private void Animations()
    {
        anim.SetFloat("xVelocity", rb.linearVelocity.x);
    }

    private void HandleMovement()
    {
        rb.linearVelocity = new Vector2(xInput * moveSpeed, rb.linearVelocity.y);
    }
}
