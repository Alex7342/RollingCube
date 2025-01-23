using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool blockPlayerMovement = false;

    public Rigidbody rb;

    public float speed = 1f;

    private void FixedUpdate()
    {
        if (blockPlayerMovement == true)
        {
            return;
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * speed, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * speed, ForceMode.VelocityChange);
        }
    }
}
