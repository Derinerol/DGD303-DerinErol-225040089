using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Speed of the ship

    private Vector2 screenBounds; // Screen boundaries for clamping

    void Start()
    {
        // Calculate screen boundaries based on the camera's size
        Camera mainCamera = Camera.main;
        screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z));
    }

    void Update()
    {
        // Get input for movement (arrow keys or WASD)
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // Move the player
        Vector3 movement = new Vector3(moveX, moveY, 0) * speed * Time.deltaTime;
        transform.position += movement;

        // Clamp the player's position to stay within screen bounds
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, -screenBounds.x, screenBounds.x),
            Mathf.Clamp(transform.position.y, -screenBounds.y, screenBounds.y),
            transform.position.z
        );
    }
}
