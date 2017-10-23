using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;



public class PlayerTeleport : MonoBehaviour {

    private LineRenderer _LineRenderer; // used to show controller direction

	// Use this for initialization
	void Start () {
        _LineRenderer = GetComponent<LineRenderer>();
        _LineRenderer.enabled = false;
        _LineRenderer.positionCount = 2;    // 0 = start. 1 = end
    }
	
	// Update is called once per frame
	void Update () {

        // Get touchpad down
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            // Show lineRenderer
            _LineRenderer.enabled = true;

            // Raycast to find teleport location
            Vector3 rayPosition

            // Get touchpadXY input => _TeleportRotation

        }


        // Get touchpad Up
        if (Input.GetMouseButtonUp(0))
        {

            Vector2 touchPadXY = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
            Vector3 teleportLocation; //raycast hit with level
            Vector2 teleportRotation = new Vector2 (Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")); // Touchpad x y axis

            //transform.position = _TeleportLocation;
            //transform.rotation = _TeleportRotation;

            _LineRenderer.enabled = false;
        }



	}
}



