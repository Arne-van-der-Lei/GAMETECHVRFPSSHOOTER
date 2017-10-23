using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerTeleport : MonoBehaviour {

    private LineRenderer _LineRenderer; // used to show controller direction
    private GameObject _HandIndicator;

	// Use this for initialization
	void Start () {
        _LineRenderer = GetComponent<LineRenderer>();
        _LineRenderer.enabled = false;
        _LineRenderer.positionCount = 2;    // 0 = start. 1 = end
        //
        GameObject.CreatePrimitive(PrimitiveType.Cube);

    }
	
	// Update is called once per frame
	void Update () {

        

        // Get touchpad down
        


        // Get touchpad Up
        if (Input.GetMouseButtonUp(0))
        {
            
            Vector3 teleportLocation; //raycast hit with level
            Vector2 teleportRotation = new Vector2 (Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")); // Touchpad x y axis

            //transform.position = _TeleportLocation;
            //transform.rotation = _TeleportRotation;

            _LineRenderer.enabled = false;
        }

        // Cube on hand

	}


}



