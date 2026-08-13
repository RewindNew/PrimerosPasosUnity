using UnityEngine;

public class Playermovement : MonoBehaviour
{
[SerializeField] private Playermovement _playerMovement;
[SerializeField] private float _jumpForce = 5f;
[SerializeField] private float _movementSpeed = 5f;
[SerializeField] private Rigidbody2D _rigidbody2D;
[SerializeField] private GroundCheck _groundCheck;
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }


    private void Start()
    {

    }

    private void FixedUpdate()
    {
        if (_groundCheck.isGround)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                _rigidbody2D.AddForce(Vector2.up * _jumpForce,ForceMode2D.Force);
                
                Debug.Log("Oprimí la tecla");
            }
        }
        _rigidbody2D.linearVelocity = Vector2.right * _movementSpeed;
    }
    private void Update()
    {

    }

}
