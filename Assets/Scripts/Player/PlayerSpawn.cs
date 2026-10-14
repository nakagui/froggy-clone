using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _playerPrefab;

    private void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        Instantiate(
            _playerPrefab,
            transform.position,
            Quaternion.identity
        );
    }
}
