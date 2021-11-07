using UnityEngine;

public class PlatformPhysics : MonoBehaviour
{
    [Range(0, 1)] private float bobbingSpeed = 0.5f;

    private float initialY;
    private float startOffset;

    private void Start()
    {
        // Take initial Y position of platform
        initialY = transform.position.y;

        // Generate a random number to offset platform oscillation
        startOffset = Random.Range(-1.0f, 1.0f);

        // Alter offset number to randomize bobbing speed
        bobbingSpeed += startOffset * 0.5f;
    }

    private void Update()
    {
        // Generate a Y position by adding oscillating sine value to initial Y position;
        var newY = initialY + Mathf.Sin(Time.time + startOffset) * bobbingSpeed;

        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            ApplyPlayerCollision();
    }

    private void ApplyPlayerCollision()
    {
    }
}