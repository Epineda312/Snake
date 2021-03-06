/*
Air-ic
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

  public GameObject snakePrefab;
    public Snake head;
    public Snake tail;
    public int NESW;
    public Vector2 nextPos;

	// Use this for initialization
	void Start ()
    {
        InvokeRepeating("TimerInvoke", 0, .5f);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void TimerInvoke()
    {
        Movement();
    }

    void Movement()
    {
        GameObject temp;
        nextPos = head.transform.position;

        switch(NESW)
        {
            case 0:
                nextPos = new Vector2(nextPos.x, nextPos.y + 1);
                break;
            case 1:
                nextPos = new Vector2(nextPos.x + 1, nextPos.y);
                break;
            case 2:
                nextPos = new Vector2(nextPos.x, nextPos.y - 1);
                break;
            case 3:
                nextPos = new Vector2(nextPos.x -1, nextPos.y + 1);
                break;
        }
        temp = (GameObject)Instantiate(snakePrefab, nextPos, transform.rotation);

    }
}
