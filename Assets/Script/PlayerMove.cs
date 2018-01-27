using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject player;
    public float speed = 0.02f;
    public float rotationSpeed = 1;
    public float timer = 1f;

    
	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(speed, 0, 0);
        if (Input.GetKeyDown(KeyCode.D) || (Input.GetKeyDown(KeyCode.RightArrow)))
        {
            MoveRight();
        }
        if (Input.GetKeyDown(KeyCode.A) || (Input.GetKeyDown(KeyCode.LeftArrow)))
        {
            MoveLeft();
        }
        

    }

    public void MoveRight()
    {
        player.transform.position = new Vector3(player.transform.position.x,player.transform.position.y,player.transform.position.z - 1);
        timer -= Time.deltaTime;
        
    }

    public void MoveLeft()
    {
        player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z + 1);
    }


}
