using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private InputManager inputManager;

    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        inputManager.OnMove.AddListener(MovePlayer);

        rb = GetComponent<Rigidbody>();
    }

    private void MovePlayer(Vector2 direction)
    {
        Vector3 moveDirection = new(direction.x, 0f, direction.y);
        rb.AddForce(speed * moveDirection);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
