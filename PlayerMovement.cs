using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody2D playerBody;

    [Header("Movement")]
    [SerializeField] private float moveSpeed = 750f;
    [SerializeField] private float jumpHeight = 10f;

    [Header("Input")]
    private float _inputVector;
    private bool _jumpPressed;

    [SerializeField] private Vector2 groundedBoxSize;
    [SerializeField] private LayerMask groundLayer;
    private bool _isGrounded;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         // Getting Player Rigidbody 2D
        playerBody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

        // Getting Player Input
        _inputVector = Input.GetAxis("Horizontal");

        // Checking if Player is still on the ground
        _isGrounded = Physics2D.OverlapBox(new Vector2(transform.position.x, transform.position.y - 0.5f), groundedBoxSize, 0f, groundLayer);

        // Verticle Movement Based on Space-Bar [Velocity = SquareRoot(2 * gravity * Height)]
        _jumpPressed = Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow);
        if (_jumpPressed && _isGrounded)
            playerBody.linearVelocityY = Mathf.Sqrt(2 * Mathf.Abs(Physics2D.gravity.y) * jumpHeight);
    }

     private void FixedUpdate()
    {
        // Horizontal Movement Based on W-A-S-D Keys or Arrow Keys
        playerBody.linearVelocityX = _inputVector * moveSpeed * Time.deltaTime;
    }


}
