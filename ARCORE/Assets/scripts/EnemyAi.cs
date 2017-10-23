using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyAi : MonoBehaviour
{
    public GameObject Camera;
    public float range = 10;

    void Start()
    {
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
        if (!Camera)
        {
            Debug.Log("Make sure your Main Camera is tagged!!");
        }
    }

    void Update()
    {
        //rotate to look at the player
        float distance = Vector3.Distance(transform.position, Camera.transform.position);

        if (distance < range)
        {
            //gameObject.GetComponent<NavMeshAgent>().enabled = true;
            GetComponent<NavMeshAgent>().destination = Camera.transform.position;
        }
        else
        {
            // gameObject.GetComponent<NavMeshAgent>().enabled = false;
            transform.LookAt(new Vector3(Camera.transform.position.x, transform.position.y, Camera.transform.position.z));
        }

    }



}