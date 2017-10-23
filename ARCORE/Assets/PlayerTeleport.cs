using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;



public class PlayerTeleport : MonoBehaviour {

    private LineRenderer _LineRenderer; // used to show controller direction
    private GameObject _HandIndicator;

	// Use this for initialization
	void Start () {
        _LineRenderer = GetComponent<LineRenderer>();
        _LineRenderer.enabled = false;
        _LineRenderer.positionCount = 2;    // 0 = start. 1 = end
        _LineRenderer.SetPosition(0, OVRInput.GetLocalControllerPosition(Controller));

        //
        GameObject.CreatePrimitive(PrimitiveType.Cube);

    }
	
	// Update is called once per frame
	void Update () {

        

        // Get touchpad down
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            // Show lineRenderer
            _LineRenderer.enabled = true;

            // Raycast to find teleport location
            Vector3 controllerDirection = Quaternion.ToEulerAngles(OVRInput.GetLocalControllerRotation(Controller));
            Vector3 controllerPosition = OVRInput.GetLocalControllerPosition(Controller);

            //Ray ray = new Ray(controllerPosition, controllerDirection);
            RaycastHit rayHit;
            if (Physics.Raycast(controllerPosition, controllerDirection, out rayHit,100f))
            {
                _LineRenderer.SetPosition(1, rayHit.point);
            }
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

        // Cube on hand
        _HandIndicator.transform.position = OVRInput.GetLocalControllerPosition(Controller);

	}

    public bool ControllerIsConnected
    {
        get
        {
            OVRInput.Controller controller = OVRInput.GetConnectedControllers() & (OVRInput.Controller.LTrackedRemote | OVRInput.Controller.RTrackedRemote);
            return controller == OVRInput.Controller.LTrackedRemote || controller == OVRInput.Controller.RTrackedRemote;
        }
    }
    public OVRInput.Controller Controller
    {
        get
        {
            OVRInput.Controller controller = OVRInput.GetConnectedControllers();
            if ((controller & OVRInput.Controller.LTrackedRemote) == OVRInput.Controller.LTrackedRemote)
            {
                return OVRInput.Controller.LTrackedRemote;
            }
            else if ((controller & OVRInput.Controller.RTrackedRemote) == OVRInput.Controller.RTrackedRemote)
            {
                return OVRInput.Controller.RTrackedRemote;
            }
            return OVRInput.GetActiveController();
        }
    }

}



