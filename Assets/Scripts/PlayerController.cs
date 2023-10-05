using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.04f; // Field

    // Update is called once per frame
    void Update()
    {
        Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
        transform.Translate(0, 0, speed);
        bool isKeyWasJustPressed = Input.GetKeyDown(KeyCode.Space); //Checks if Space is pressed
        if (isKeyWasJustPressed && IsTouchingGround())
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(0, 500, 0);
            rb.angularVelocity = new Vector3(2, 0, 0);
        }
        transform.Translate(0, 0, speed, Space.World);
        
        if (Input.GetKey(KeyCode.LeftArrow))  
        {  
            this.transform.Rotate(Vector3.up, -.5f);  
        }  
        
        if (Input.GetKey(KeyCode.RightArrow))  
        {  
            this.transform.Rotate(Vector3.up, .5f);  
        }

        if (rigidbody.velocity.y < -.1f)
        {
            rigidbody.AddForce(0, .5f, 0);
        }
    }
    
    private void FixedUpdate()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(Physics.gravity * GetComponent<Rigidbody>().mass);
    }

    bool IsTouchingGround()
    {
        int layerMask = LayerMask.GetMask("Ground");
        return Physics.CheckBox(transform.position, transform.lossyScale / 1.99f, transform.rotation, layerMask);
    }
}
