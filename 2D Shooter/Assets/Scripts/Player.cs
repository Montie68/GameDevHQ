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
    [SerializeField] private float speed = 3.5f;
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
        // check if the controls on the horizontal and vertical axis are pressed.
        // if right move +x or -x if left
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        transform.Translate(Vector3.up * verticalInput * speed * Time.deltaTime);

    }
    #endregion
    #region Public Methods
    // Place your public methods here

    #endregion
    #region Private Methods
    // Place your public methods here

    #endregion

}
