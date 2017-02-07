using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

    int x,y;

	// Use this for initialization
	void Start () {
        x=0;
        y=0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            x--;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            x++;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            y++;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            y--;
        }
        this.transform.Translate(x, y, 0);
        x = 0;
        y = 0;
	}
}
