using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{

    //var myTransform : Transform; //current transform data of this enemy
    Transform myTransform;
    //var target : Transform; //the enemy's target
    Transform target;
    //var moveSpeed = 3; //move speed
    public float zombieSpeed = 1f;
    //var rotationSpeed = 3; //speed of turning


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("PlayerTag").transform; //target the player
    }

    // Update is called once per frame
    void Update()
    {
        ZombieMovementFunc();
        
    }

    void ZombieMovementFunc()
    {
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, zombieSpeed * Time.deltaTime);

        }
    }

}
