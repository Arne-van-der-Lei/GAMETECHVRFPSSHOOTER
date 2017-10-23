using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public float LaunchSpeed = 10f;

    public float TimeBetweenShots = 1.0f;
    private float _Timer = 0f;
    public GameObject Projectile;

	// Use this for initialization
	void Start () {

        if (Projectile == null)
        {
            Projectile = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            Projectile.AddComponent<Rigidbody>();
            Projectile.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        }
		
	}
	
	// Update is called once per frame
	void Update () {

        _Timer += Time.deltaTime;

        if (_Timer >= TimeBetweenShots)
        {
            _Timer = 0f;
            Fire();
        }

	}

    private void Fire()
    {
        GameObject projectile = Instantiate(Projectile, Camera.main.transform.position, Camera.main.transform.rotation) as GameObject;
        projectile.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * LaunchSpeed, ForceMode.VelocityChange);

    }
}
