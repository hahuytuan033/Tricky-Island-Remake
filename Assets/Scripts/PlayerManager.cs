using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [Header("Player Settings")]
    [SerializeField] private float moveSpeed;
    private Rigidbody2D rb;
    private float xInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        HandleMovement();
    }

    private void HandleMovement()
    {
        rb.linearVelocity = new Vector2(xInput * moveSpeed, rb.linearVelocity.y);
    }
}
