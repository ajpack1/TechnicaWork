using UnityEngine;
using UnityEngine.InputSystem;

public class RotateObject : MonoBehaviour
{
    public Vector3 speed; // Public speed Vector


    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.isPressed)
            transform.Rotate(speed * Time.deltaTime); // Rotate it on set axis by specified speed with respect to delta time
        
    }
}
