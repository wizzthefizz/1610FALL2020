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
        
        transform.rotation = Quaternion.Euler(0,rotateValue,0);
    }
}
