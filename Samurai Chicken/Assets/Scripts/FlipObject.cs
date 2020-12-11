using UnityEngine;

public class FlipObject : MonoBehaviour
{
    private float rotateValue;
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rotateValue = 90;
        }
        
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rotateValue = 270;
        }
        
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            rotateValue = 180;
        }
        
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            rotateValue = 0;
        }
        
        transform.rotation = Quaternion.Euler(0,rotateValue,0);
    }
}
