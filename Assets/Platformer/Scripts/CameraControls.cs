using UnityEngine;

public class CameraControls : MonoBehaviour
{
    public float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 rightMovement = transform.right * horizontalInput;
        transform.position += rightMovement * moveSpeed * Time.deltaTime;
    }
}
