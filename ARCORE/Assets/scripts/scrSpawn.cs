using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
spawner will spawn <_spawnLimit> number of zombies 
 */

public class scrSpawn : MonoBehaviour
{
    [SerializeField]
   // public GameObject _zombie;
    private GameObject _zombie;
    private float _spawnTime;
    const float _countdownTime = 2.0f;
    const float _spawnOffset = 2.0f;

    // Use this for initialization

    void Start()
    {
        ///_zombie = GameObject.FindGameObjectWithTag("Zombie");
        _spawnTime = _countdownTime;

    }

    // Update is called once per frame
    void Update()
    {
        _spawnTime -= Time.deltaTime;
        //make an instance of enemy
        if (_spawnTime <= 0.0f )
        {
            _spawnTime = _countdownTime;
            float posX = Random.Range(-_spawnOffset, _spawnOffset) + gameObject.transform.position.x;
            float posZ = Random.Range(-_spawnOffset, _spawnOffset) + gameObject.transform.position.z;
            Vector3 spawnPos = new Vector3( posX, gameObject.transform.position.y, posZ );
            Instantiate(_zombie, spawnPos, gameObject.transform.rotation);
        }

    }
}
