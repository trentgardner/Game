using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    void Update()
    {
        Vector3 direction = Vector3.zero;

        if (Keyboard.current.wKey.isPressed) direction.y += 1;
        if (Keyboard.current.sKey.isPressed) direction.y -= 1;
        if (Keyboard.current.aKey.isPressed) direction.x -= 1;
        if (Keyboard.current.dKey.isPressed) direction.x += 1;

        transform.position += direction.normalized * moveSpeed * Time.deltaTime;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
}
