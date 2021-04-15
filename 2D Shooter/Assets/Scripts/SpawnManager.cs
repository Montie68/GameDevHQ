using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private Float2 m_spawnRange = new Float2(0, 5);
    [SerializeField]
    private GameObject m_enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
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
            yield return new WaitForSeconds(Random.Range(m_spawnRange.a, m_spawnRange.b));
        }
    }
}