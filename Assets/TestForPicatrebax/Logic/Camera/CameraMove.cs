using UnityEngine;

public class CameraMove : MonoBehaviour
{   
    [SerializeField] private Transform target;
    [SerializeField] Vector3 offset;
    [SerializeField] private float smoothness = 0.175f;
    private Vector3 velocity = Vector3.zero;

    private void LateUpdate()
    {
        Vector3 desiredPosition = new Vector3(target.position.x,0) + offset;
        transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothness);
    }
}
