using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerInputHandler))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;
    private Rigidbody2D _rigidbody;
    private PlayerInputHandler _input;
    private bool _isDead = false;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _input = GetComponent<PlayerInputHandler>();
    }

    private void FixedUpdate()
    {
        _rigidbody.linearVelocity = _input.MoveInput * _speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_isDead)
        {
            return;
        }

        if (collision.CompareTag("Car"))
        {
            _isDead = true;
            Destroy(gameObject);
            PlayerSpawn playerSpawn = FindAnyObjectByType<PlayerSpawn>();
            playerSpawn.Spawn();
        }
    }
}
