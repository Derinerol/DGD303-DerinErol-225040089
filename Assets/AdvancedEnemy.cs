using UnityEngine;

public class AdvancedEnemy : MonoBehaviour
{
    public float speed = 2f; // Movement speed
    public float zigzagAmplitude = 2f; // Zigzag width
    public float zigzagFrequency = 2f; // Zigzag speed

    void Update()
    {
        // Zigzag movement
        float xOffset = Mathf.Sin(Time.time * zigzagFrequency) * zigzagAmplitude;
        transform.position += new Vector3(xOffset, -speed, 0) * Time.deltaTime;
    }
}
