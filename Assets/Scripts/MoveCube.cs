using UnityEngine;

public class MoveCube : MonoBehaviour
{
    [SerializeField] private float _speedRotarion;
    [SerializeField] private float _speedMove;
    [SerializeField] private float _speedScale;

    private void Update()
    {
        Vector3 nextPosition = transform.position;
        nextPosition.z += _speedMove;
        transform.position = nextPosition;

        transform.localScale += Vector3.one * _speedScale * Time.deltaTime;

        transform.Rotate(Vector3.up, _speedRotarion * Time.deltaTime);
    }
}
