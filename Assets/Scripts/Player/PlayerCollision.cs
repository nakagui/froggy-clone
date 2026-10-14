using UnityEngine;

[RequireComponent(typeof(PlayerLife))]
public class PlayerCollision : MonoBehaviour
{
    private PlayerLife _playerHealth;

    private void Awake()
    {
        _playerHealth = GetComponent<PlayerLife>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Car"))
        {
            _playerHealth.Die();
        }
    }
}
