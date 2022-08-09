using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public int zoomSped2D;
    public int minZoom2D, maxZoom2D;

    public int zoomSped3D;
    public int minZoom3D, maxZoom3D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(Input.GetAxis("Mouse ScrollWheel"));
        if (Camera.main.orthographic)
        {
            if(Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                //zoom in
                Camera.main.orthographicSize -= zoomSped2D * Time.deltaTime;
                
            }
            if(Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                Camera.main.orthographicSize += zoomSped2D * Time.deltaTime;
            }

            Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, minZoom2D, maxZoom2D);
        }   
        else 
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                //zoom in
                Camera.main.fieldOfView -= zoomSped3D * Time.deltaTime;
            }
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                Camera.main.fieldOfView+= zoomSped3D * Time.deltaTime;
            }

            Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, minZoom3D, maxZoom3D);
        }
    }
}
