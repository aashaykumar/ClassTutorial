using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int playerx = 0;
    int playery = 0;
    int targetx = 0;
    int targety = 0;
    bool win = false;
    // Start is called before the first frame update
    void Start()
    {
        playerx = Random.Range(-10, 10);
        playery = Random.Range(-15, 15);
        Debug.Log("current player postion:" + playerx + " " + playery);
        targetx = Random.Range(-10, 10);
        targety = Random.Range(-15, 15);
        Debug.Log("Goal Post postion:" + targetx + " " + targety);
    }

    // Update is called once per frame
    void Update()
    {
        detectInput();
        callGPS();
        if (playerx == targetx && playery == targety && !win)
        {
            Debug.Log("Player Wins");
            win = true;
        }
    }

    void detectInput()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerx = playerx - 1;
            Debug.Log("Player moved left and current position is" + playerx + "," + playery);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            playery = playery + 1;
            Debug.Log("Player moved up and current position is" + playerx + "," + playery);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            playery = playery - 1;
            Debug.Log("Player moved bottom and current position is" + playerx + "," + playery);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            playerx = playerx + 1;
            Debug.Log("Player moved right and current position is" + playerx + "," + playery);
        }

    }

    void callGPS()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            int distx = targetx - playery;
            int disty = targety - playery;
            Debug.Log("Distance between player an goal post is: Xunit :" + distx + ",Yunit :" + disty);
        }
    }
}
