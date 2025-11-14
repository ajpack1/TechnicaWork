using UnityEngine;
using UnityEngine.InputSystem;

public class MoverInput : MonoBehaviour
{
    public float speed; // Set the speed in the inspector

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.upArrowKey.isPressed) // Up arrow
        {
            Vector3 newPos = transform.position; // Gets current position of the object this script is attatched to
            newPos.z = newPos.z + speed * Time.deltaTime; // We can not directly modify transform.position - reason for newPos creation
                                                          // Add on the current distance to travel to the current position of the object
            transform.position = newPos; // Reassign the value back to transform.position 
        }
        if (Keyboard.current.downArrowKey.isPressed) // Down arrow
        {
            Vector3 newPos = transform.position;
            newPos.z = newPos.z + speed * -1f * Time.deltaTime; // Flip the sign to go other direction
                                                                // Along the z axis
            transform.position = newPos;
        }
        if (Keyboard.current.leftArrowKey.isPressed) // Left Arrow
        {
            Vector3 newPos = transform.position;
            newPos.x = newPos.x + speed * -1f * Time.deltaTime; // Along the x axis
            transform.position = newPos;
        }
        if (Keyboard.current.rightArrowKey.isPressed) // Right arrow
        {
            Vector3 newPos = transform.position;
            newPos.x = newPos.x + speed * Time.deltaTime;
            transform.position = newPos;
        }
    }
}
