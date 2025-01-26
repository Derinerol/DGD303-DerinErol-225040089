using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float scrollSpeed = 0.1f; // Speed of the scrolling
    private Vector2 offset;         // Offset for scrolling
    private Material backgroundMaterial;

    void Start()
    {
        // Get the material from the SpriteRenderer
        backgroundMaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        // Calculate the new offset
        offset = new Vector2(0, Time.time * scrollSpeed);

        // Apply the offset to the material
        backgroundMaterial.mainTextureOffset = offset;
    }
}
