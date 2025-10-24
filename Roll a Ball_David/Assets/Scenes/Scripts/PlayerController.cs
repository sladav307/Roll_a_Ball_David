using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb; 
    public float speed;
    public AudioClip pickupSound;

    private void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("PickUp"))
        {   
            if (pickupSound != null)
            {
                AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            }
            
            // Objekt deaktivieren
            other.gameObject.SetActive(false);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       rb = GetComponent <Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveX = 0f; // Left/right movement
        float moveZ = 0f; // Forward/backward movement

        // Horizontal input (x-axis)
        if (Input.GetKey(KeyCode.LeftArrow))
            moveX = -1f;
        else if (Input.GetKey(KeyCode.RightArrow))
            moveX= 1f;

        // Vertical Input (y-axis)
         if (Input.GetKey(KeyCode.UpArrow))
            moveZ = 1f;
        else if (Input.GetKey(KeyCode.DownArrow))
            moveZ= -1f;
    
    // Create a movement vector
    Vector3 movement = new Vector3(moveX, 0f, moveZ);
    rb.AddForce(movement * speed, ForceMode.Force);

    }
}
