using UnityEngine;
using UnityEngine.InputSystem;

public class RigidbodyMove : MonoBehaviour
{
    private Rigidbody rb; // Rigidbody reference

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();  // Get component - using gameObject looks on object who has this script
       
    }

    // Update is called once per frame
    void FixedUpdate() // Fixed update - physics - consistent force
    {

        if (Keyboard.current.upArrowKey.isPressed)
        {
            rb.AddRelativeForce(Vector3.forward, ForceMode.Impulse); // Adds the force in that way - so, object can have force properly applied and can still spin
        }
        if (Keyboard.current.leftArrowKey.isPressed)
        {

            rb.AddRelativeForce(Vector3.right * -1, ForceMode.Impulse); // * -1 to invert it - there is no vector3.left
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            rb.AddRelativeForce(Vector3.forward * -1, ForceMode.Impulse);
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            rb.AddRelativeForce(Vector3.right, ForceMode.Impulse);
        }

    }
}
