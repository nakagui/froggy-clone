using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    private bool _isDead;

    public void Die()
    {
        if (_isDead)
        {
            return;
        }

        _isDead = true;
        PlayerSpawn playerSpawn = FindAnyObjectByType<PlayerSpawn>();

        if (playerSpawn != null)
        {
            playerSpawn.Spawn();
        }

        Destroy(gameObject);
    }
}
