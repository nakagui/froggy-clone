using UnityEngine;

[RequireComponent(typeof(PlayerLife))]
public class PlayerCollision : MonoBehaviour
{
    private PlayerLife _playerLife;

    private void Awake()
    {
        _playerLife = GetComponent<PlayerLife>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Car"))
        {
            _playerLife.Die();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Goal"))
        {
            ScoreManager.Instance.AddScore();
        }
    }
}
