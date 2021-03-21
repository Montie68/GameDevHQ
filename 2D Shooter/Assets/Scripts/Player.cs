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
    [SerializeField] GameObject m_laserPrefab = null;
    [SerializeField] Vector3 m_laserOffset = new Vector3();
    [SerializeField] float m_laserCoolDown = 1f;
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
        CalcMovement();
        FireLaser();
    }
    #endregion
    #region Public Methods
    // Place your public methods here

    #endregion
    #region Private Methods
    // Place your public methods here
    void FireLaser()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(m_laserPrefab, transform.position + m_laserOffset, Quaternion.identity);
        }
    }
    void CalcMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        Vector3 dir = new Vector3(horizontalInput, verticalInput, 0);

        transform.Translate(dir * m_speed * Time.deltaTime);

        transform.position = new Vector2(transform.position.x,
                                        Mathf.Clamp(transform.position.y, -4.5f, 1.5f));

        if (transform.position.x > 11.3f)
        {
            //move to the LHS
            transform.position = new Vector2(-11.3f, transform.position.y);
        }
        // if the player goes out of the LHS
        else if (transform.position.x < -11.3f)
        {
            // Move to the RHS
            transform.position = new Vector2(11.3f, transform.position.y);
        }
    }
    #endregion

}
