using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject player;
    public float speed;

    
	// Use this for initialization
	void Start ()
    {

        
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(speed, 0, 0);
        MoveRight();
    }

    public void MoveRight()
    {
        float right = Input.GetAxis("Vertical") * speed;
        Debug.Log("Bang");
    }
}
