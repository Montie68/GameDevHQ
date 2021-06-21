using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private Float2 m_spawnRange = new Float2(0, 5);
    [SerializeField]
    private GameObject m_enemyPrefab;
    // Game Object Container as the parent for the enemy prefabs
    [SerializeField]
    private Transform m_enemyObjectContainer;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
        if (m_enemyObjectContainer == null) m_enemyObjectContainer = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnEnemy()
    {
        while (Application.isPlaying)
        {
            Vector3 pos = new Vector3( Random.Range(-8.0f, 8.0f), 9);
            GameObject _enemy = Instantiate(m_enemyPrefab, pos, Quaternion.identity);
            _enemy.transform.parent = m_enemyObjectContainer;
            yield return new WaitForSeconds(Random.Range(m_spawnRange.a, m_spawnRange.b));
        }
    }
}