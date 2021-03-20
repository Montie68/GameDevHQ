using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region Public
    // public members go here
    #endregion

    #region Private
    // private members go here
    [SerializeField] private float m_speed = 3.5f;
    #endregion
    // Place all unity Message Methods here like OnCollision, Update, Start ect. 
    #region Unity Messages 
    void Start()
    {
        // take the current Position  = new Position (0,0,0)
        gameObject.transform.position = new Vector3(0,0,0);
    }
	
    void Update()
    {
       
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(horizontalInput, verticalInput, 0);
        // check if the controls on the horizontal and vertical axis are pressed.
        // if right key move +x or -x if left key
        // if the key down move -y and if up key move +y 
        transform.Translate(dir * m_speed * Time.deltaTime);
        // clamp the the player to the top and bottom of the screen
        // if at bottom
        if (transform.position.y < -4.5f )
        {
            // make the pleyer y value 4.5f
            transform.position = new Vector2(transform.position.x, -4.5f);
        }
        // if the postion is greater than 4.5f
        else if(transform.position.y > 4.5f)
        {
            // clamp the y postion to 4.5f
            transform.position = new Vector2(transform.position.x, 4.5f);
        }

        // make the player wrap around to the other side if the player goes 
        // hoizontally off the screen
        // gone out of the right hand side 
        if (transform.position.x > 11)
        {
            //move tot the LHS
            transform.position = new Vector2(-11, transform.position.y);
        }
        // if the player goes out of the LHS
        else if(transform.position.x < -11)
        {
            // Move to the RHS
            transform.position = new Vector2(11, transform.position.y);
        }
        

    }
    #endregion
    #region Public Methods
    // Place your public methods here

    #endregion
    #region Private Methods
    // Place your public methods here

    #endregion

}
