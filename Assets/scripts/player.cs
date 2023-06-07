using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D igrok;
    public Vector2 direction;
    private void Start()
    {
        igrok = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate()
    {
        igrok.MovePosition(igrok.position + direction * speed);
    }
}
