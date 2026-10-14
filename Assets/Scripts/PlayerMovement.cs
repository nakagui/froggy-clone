using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerInputHandler))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;
    private Rigidbody2D _rigidbody;
    private PlayerInputHandler _input;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _input = GetComponent<PlayerInputHandler>();
    }

    private void FixedUpdate()
    {
        _rigidbody.linearVelocity = _input.MoveInput * _speed;
    }
}
