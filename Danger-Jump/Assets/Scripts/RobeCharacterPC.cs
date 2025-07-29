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
        body.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.linearVelocityY);

        // Loop to check for jump
        if (Input.GetKey(KeyCode.Space))
            body.linearVelocity = new Vector2(body.linearVelocityX, jump);
    }

    void FixedUpdate()
    {
        // Best for movement
    }
}
