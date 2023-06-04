using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform target1;
    [SerializeField] private Vector3 offset = new Vector3(0f, 0f, -10f);

    private void LateUpdate()
    {
        if (target1 != null)
        {
            transform.position = target1.position + offset;
        }
    }
}
