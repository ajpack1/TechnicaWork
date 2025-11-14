using UnityEngine;

public class StartUpdate : MonoBehaviour
{
    private int updateCount = 0; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello I am in start! I print once. Update Count is: " + updateCount);
    }

    // Update is called once per frame
    void Update()
    {
        updateCount++;

        // Printing can be a bit slow - not accruate to how fast update is called
        Debug.Log("Hello I am in update! I am called as fast as possible every frame! Update Count is: " + updateCount);
        
    }
}
