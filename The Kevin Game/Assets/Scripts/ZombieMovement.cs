using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieMovement : MonoBehaviour
{

    //var myTransform : Transform; //current transform data of this enemy
    Transform myTransform;
    //var target : Transform; //the enemy's target
    [SerializeField]
    Transform target;
    //var moveSpeed = 3; //move speed
    public float zombieSpeed = 1f;
    float rotationSpeed = 1f;
    //var rotationSpeed = 3; //speed of turning
    NavMeshAgent agent;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("PlayerTag").transform; //target the player

        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        //ZombieMovementFunc();
        if(target != null)
        {
            agent.SetDestination(target.position);

        }

        if (target != null)
        {
            if (Vector3.Distance(transform.position, target.position) > .5f)
            {
                RotateTowards(target.position);
            }

        }


            

    }

    //void ZombieMovementFunc()
    //{
    //    if (target != null)
    //    {
    //        Vector3 newTarget = target.transform.position;
    //        newTarget = new Vector3(target.transform.position.x, target.transform.position.y - .4f, 0f);
    //        transform.position = Vector3.MoveTowards(transform.position, newTarget, zombieSpeed * Time.deltaTime);

    //    }
    //}

    private void RotateTowards(Vector2 target)
    {
        var offset = 0f;
        Vector2 direction = target - (Vector2)transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle + offset, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }

    //void FlipZombieFunc()
    //{
    //    if (target != null)
    //    {
    //        //if (target.position.x > transform.position.x)
    //        //{
    //        //    //face right
    //        //    transform.localScale = new Vector3(.06f, .06f, 1f);
    //        //}
    //        //else if (target.position.x < transform.position.x)
    //        //{
    //        //    //face left
    //        //    transform.localScale = new Vector3(-.06f, .06f, 1f);
    //        //}

            
    //    }
            
    //}

}
