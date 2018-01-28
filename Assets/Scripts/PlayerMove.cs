using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject player;
    public float speed = 0.02f;
    public float HorizontalMove = 1;
    public float rotationSpeed = 1;
    public float timer = 1f;
    public Transform CenterCol;
    public Transform RightCol;
    public Transform LeftCol;
    private bool InRightCol = false;
    private bool InLeftCol = false;


    // Use this for initialization
    void Start () {}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(0, 0, speed);
        if (Input.GetKeyDown(KeyCode.A) || (Input.GetKeyDown(KeyCode.LeftArrow)) && player.transform.position.x < 2)
        {
            if(!InLeftCol)
                MoveLeft();
        }
        if (Input.GetKeyDown(KeyCode.D) || (Input.GetKeyDown(KeyCode.RightArrow)) && player.transform.position.x > -2)
        {
            if (!InRightCol)
                MoveRight();
        }


    }
    public void MoveLeft()
    {
        player.transform.position += LeftCol.position;
        //InLeftCol = true;
        //InRightCol = false;
        //player.transform.position = new Vector3(player.transform.position.x - HorizontalMove, player.transform.position.y,player.transform.position.z );
        timer -= Time.deltaTime;
    }
    public void MoveRight()
    {
        player.transform.position += RightCol.position;
        //InRightCol = true;
        //InLeftCol = false;
        //player.transform.position = new Vector3(player.transform.position.x - HorizontalMove, player.transform.position.y,player.transform.position.z );
        timer -= Time.deltaTime;

    }
   


}
