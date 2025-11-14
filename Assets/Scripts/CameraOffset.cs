using UnityEngine;

public class CameraOffset : MonoBehaviour
{
    public GameObject objFollow;
    private Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 newPos = objFollow.transform.position; // Copy the position from object - read only value
        newPos.z -= 4; // Move back on z axis by 4
        gameObject.transform.position = newPos; // Set position = gameObject accesses object who has this script on it

        offset = objFollow.transform.position - gameObject.transform.position; // Calculate offset to maintain 


    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = objFollow.transform.position - offset; // Maintain offset
    }
}
