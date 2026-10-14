using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _carPrefab;
    [SerializeField] private int _direction;
    [SerializeField] private float _spawnCooldown = 3f;

    private void Update()
    {
        if (_spawnCooldown >= 0)
        {
            _spawnCooldown -= Time.deltaTime;
            return;
        }
        Spawn();
        _spawnCooldown = Random.Range(0, 4);
    }

    private void Spawn()
    {
        _carPrefab.GetComponent<CarMovement>().Direction = _direction;
        GameObject carObject = Instantiate(
            _carPrefab,
            transform.position,
            Quaternion.identity
        );
        Destroy(carObject, 15f);
    }
}
