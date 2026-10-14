using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;

    private void Update()
    {
        transform.position += new Vector3(_speed * Time.deltaTime, 0);
    }
}
