using UnityEngine;

public class RobeCharacterPC : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jump = 5f;

    //Start is called before the first frame update
    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame (Best for input)
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.linearVelocity = new Vector2(horizontalInput * speed, body.linearVelocityY);

        // Flips Sprite right and left
        if (horizontalInput > 0.01f)
            transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-0.4f, 0.4f, 0.4f);

        // Loop to check for jump
        if (Input.GetKey(KeyCode.Space))
            body.linearVelocity = new Vector2(body.linearVelocityX, jump);
    }

    void FixedUpdate()
    {
        // Best for movement
    }
}
