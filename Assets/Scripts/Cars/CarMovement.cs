using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    public int Direction = 1;

    private void Update()
    {
        transform.position += new Vector3(_speed * Direction * Time.deltaTime, 0);
    }
}
