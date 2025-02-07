using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 200f;
    private float moveInput = 0f;
    private Rigidbody2D rBody;

    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rBody.linearVelocityX = moveInput * moveSpeed * Time.fixedDeltaTime;
        if (rBody.linearVelocityY > 0f)
        {
            rBody.linearVelocityY = 0f;
        }
    }
}
