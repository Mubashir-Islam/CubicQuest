using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public Transform TargetCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        // Check if the user has clicked or touched the screen
        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            // Get the screen point where the user clicked or touched
            Vector3 screenPoint = Input.mousePosition;
            if (Input.touchCount > 0)
            {
                screenPoint = Input.GetTouch(0).position;
            }

            // Generate a ray from the camera through the screen point
            Ray ray = Camera.main.ScreenPointToRay(screenPoint);

            // Perform the raycast
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // The ray hit a collider in the scene, do something with the hit information
                Debug.Log("Hit object: " + hit.transform.name + ", hit point: " + hit.point);
                if (hit.transform.GetComponent<CubeSurface>())
                {
                    TargetCube = hit.transform.parent;
                }
                else if (hit.transform.GetComponent<Cube>())
                {
                    TargetCube = hit.transform;
                }
            }
            else
            {
                // The ray did not hit anything in the scene
                Debug.Log("Raycast did not hit anything.");
            }
        }
    }

}
