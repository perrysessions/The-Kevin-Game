using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZombieSpawn : MonoBehaviour
{

    Scene scene;
    float timer = 2;
    public GameObject zombiePrefab;
    public GameObject playerGO;
    // Start is called before the first frame update
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("Active Scene is '" + scene.name + "'.");
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnZombieFunc();
    }



    void SpawnZombieFunc()
    {
        timer -= Time.deltaTime;
        if(timer <= 0 && playerGO != null)
        {
            //Instantiate
            Instantiate(zombiePrefab, new Vector3(-2, 4, 0), Quaternion.identity);
            timer = 2;
        }
    }


    //Debug.Log("what scene is set to: " + scene);
    //    if (scene.name == "Main")
    //    {
    //        Debug.Log("Ready to spawn zombie");
    //        //Instantiate
    //    }
}
