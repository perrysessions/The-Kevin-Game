using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    float playerHealth = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ZombieTag")
        {
            Debug.Log("zombie touched you!!");
            playerHealth -= 1;
            if(playerHealth <= 0)
            {
                Object.Destroy(gameObject);
            }
            
        }
        //else if (other.gameObject.tag == "Player1GoalTag" && baseExistBool == true)
        //{
        //    photonView.RPC("Player1MoneyIncrease", RpcTarget.All);
        //}


    }
}
