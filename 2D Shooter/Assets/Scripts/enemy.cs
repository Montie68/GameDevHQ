using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    #region Public
    //public members go here

    #endregion

    #region Private
    //private members go here
    [SerializeField] float m_speed = 4.0f;
  #endregion
  // Place all unity Message Methods here like OnCollision, Update, Start ect. 
  #region Unity Messages 
    void Start()
    {
		
    }
	
    void Update()
    {
        UpdateMovement();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "playerProjectile")
        {
            Spawn();
        }
    }
    #endregion
    #region Public Methods
    //Place your public methods here
    private void UpdateMovement()
    {
        transform.Translate(Vector3.down * m_speed * Time.deltaTime);
        if (transform.position.y < -7f)
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        float randomX = Random.Range(-8, 8f);
        transform.position = new Vector3(randomX, 7, 0);
    }

    #endregion
    #region Private Methods
    //Place your public methods here

    #endregion

}
