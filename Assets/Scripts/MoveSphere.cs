using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    private float _speed = 0.04f;

    private void Update()
    {
        Vector3 nextPosition = transform.position;
        nextPosition.z += _speed;
        transform.position = nextPosition;
    }
}
