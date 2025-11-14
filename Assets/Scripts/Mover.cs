using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 newVec = new Vector3(0, 4, 0); // New vector 3 to translate 4 units up on y
        gameObject.transform.position = newVec; // Assign it back
    }
}
