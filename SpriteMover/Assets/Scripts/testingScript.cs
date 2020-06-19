using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using UnityEngine;

public class testingScript : MonoBehaviour
{
    public GameObject thisShip;
    public Transform tf;
    public float speed;
    private Boolean canMoveShip = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // toggle for when the player can or cannont move the ship
        if (Input.GetKeyDown("p"))
        {
            if (canMoveShip)
            {
                canMoveShip = false;
            }
            else
            {
                canMoveShip = true;
            }
        }
        // Checks ship movement state before allowing the player the move the ship
        if (canMoveShip)
        {

            // Movement for when the shift key is held down
            if (Input.GetKey("left shift") | Input.GetKey("right shift"))
            {
                if (Input.GetKeyDown("up") | Input.GetKeyDown("w"))
                {
                    tf.localPosition = tf.localPosition + new Vector3(0, 1, 0);
                }

                if (Input.GetKeyDown("down") | Input.GetKeyDown("s"))
                {
                    tf.localPosition = tf.localPosition - new Vector3(0, 1, 0);
                }

                if (Input.GetKeyDown("left") | Input.GetKeyDown("a"))
                {
                    tf.localPosition = tf.localPosition - new Vector3(1, 0, 0);
                }

                if (Input.GetKeyDown("right") | Input.GetKeyDown("d"))
                {
                    tf.localPosition = tf.localPosition + new Vector3(1, 0, 0);
                }
            }
            else
            {
                // Movement for when the shift key is not held down
                if (Input.GetKey("up") | Input.GetKey("w"))
                {
                    tf.localPosition = tf.localPosition + new Vector3(0, speed, 0);
                }

                if (Input.GetKey("down") | Input.GetKey("s"))
                {
                    tf.localPosition = tf.localPosition - new Vector3(0, speed, 0);
                }

                if (Input.GetKey("left") | Input.GetKey("a"))
                {
                    tf.localPosition = tf.localPosition - new Vector3(speed, 0, 0);
                }

                if (Input.GetKey("right") | Input.GetKey("d"))
                {
                    tf.localPosition = tf.localPosition + new Vector3(speed, 0, 0);
                }
            }
            // Returns the starship back to the starting global (0, 0, 0)
            if (Input.GetKeyDown("space"))
            {
                tf.localPosition = new Vector3(0, 0, 0);
            }
        }
        // outside of the ship movement state, to allow use of command buttons when ship movement is disabled
        // Ends the application
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        // Makes the Starship game object inactive by setting its active state to false
        if (Input.GetKeyDown("q"))
        {
            thisShip.SetActive(false);
        }
    }
}
