using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float distance = 6f;
    public float height = 3f;
    public float mouseSpeed = 3f;

    float rotationY = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void LateUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSpeed;
        rotationY += mouseX;

        transform.rotation = Quaternion.Euler(0, rotationY, 0);

        Vector3 offset = transform.forward * -distance;
        offset.y = height;

        transform.position = player.position + offset;
    }
}
