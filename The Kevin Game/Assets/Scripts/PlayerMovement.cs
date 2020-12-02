using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float playerSpeed = 5f;
    public Vector3 newMousePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MouseMoveUnit();
    }

    public void MouseMoveUnit()
    {
        if (Input.GetMouseButtonDown(0))
        //if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("left click");
            newMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            newMousePosition.z = transform.position.z;
        }

        transform.position = Vector3.MoveTowards(transform.position, newMousePosition, playerSpeed * Time.deltaTime);

    }


}
