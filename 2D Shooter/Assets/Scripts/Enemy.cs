using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int m_DoesDamage = 25;
    public int m_health = 10;

    [SerializeField] float m_speed = 5.0f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * m_speed * Time.deltaTime);

        if (transform.position.y < -9.0f)
        {
            transform.position = new Vector3(Random.Range(-8f,8f), 9f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<Player>().m_health -= m_DoesDamage;
            Destroy(this.gameObject);
        }
        if (other.tag == "Laser")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
