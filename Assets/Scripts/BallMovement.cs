using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody rb;
    public Transform cam;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 forward = cam.forward;
        Vector3 right = cam.right;

        forward.y = 0;
        right.y = 0;

        Vector3 move = forward * z + right * x;

        rb.AddForce(move * speed);
    }
}
