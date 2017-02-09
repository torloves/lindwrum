using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class playerMove : MonoBehaviour {

    private Animator player;
    int x,y,moveFlag;

	// Use this for initialization
	void Start () {
        x = 0;
        y = 0;
        moveFlag = 3;
        player = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        player.SetInteger("movement", moveFlag);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.SetInteger("movement", 3);
            moveCheck(3);        
            x--;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.SetInteger("movement", 7);
            moveCheck(7);
            x++;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            player.SetInteger("movement", 5);
            moveCheck(5);
            y++;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            player.SetInteger("movement", 1);
            moveCheck(1);
            y--;
        }
        this.transform.Translate(x, y, 0);
        x = 0;
        y = 0;
    }

    void moveCheck(int direction)
    {
        if (moveFlag == direction)
        {
            player.SetInteger("movement", direction+1);
        }
        moveFlag = direction;
    }
}
