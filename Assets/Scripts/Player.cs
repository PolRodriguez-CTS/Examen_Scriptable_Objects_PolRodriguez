using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float speed = 5;
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        _rb.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * speed, _rb.linearVelocityY);
    }
}
