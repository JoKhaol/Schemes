using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private float speed;
    [SerializeField] private float camRotateSpeed;

    private Rigidbody rb;
    private Vector3 move;

    private Vector3 previousMousePosition;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        previousMousePosition = Input.mousePosition;
    }

    private void Update()
    {
        Move();
        //Rotate();
    }

    private void Move()
    {
        move = Vector3.zero;

        move.x = Input.GetAxis("Horizontal");
        move.z = Input.GetAxis("Vertical");

        rb.AddForce(move * speed * Time.deltaTime);
    }

    /*private void Rotate()
    {
        var currentMousePosition = Input.mousePosition;

        ///Useful code
        var delta = currentMousePosition - previousMousePosition;

        cam.transform.Rotate(delta * camRotateSpeed * Time.deltaTime);

        previousMousePosition = Input.mousePosition;
    }*/
  
}
