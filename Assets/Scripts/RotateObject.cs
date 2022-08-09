using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotateSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDrag()
    {
        float Y = Input.GetAxis("Mouse Y") * rotateSpeed;
        float X = Input.GetAxis("Mouse X") * rotateSpeed;

        transform.Rotate(Vector3.right, Y);
        transform.Rotate(Vector3.up, -X);
    }
}
