using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    private float _speed = 0.01f;

    private void Update()
    {
        Vector3 nextPosition = transform.localPosition;
        nextPosition.z += _speed;
        transform.localPosition = nextPosition;
    }
}
