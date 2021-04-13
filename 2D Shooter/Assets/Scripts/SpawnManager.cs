using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private float2 m_spawnRange = new float2(0, 5);
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

[System.Serializable]
public struct float2
{
    public float a;
    public float b;
    public float2(float _a, float _b)
    {
        a = _a;
        b = _b;
    }
    public float2(float _ab)
    {
        a = b = _ab;
    }
    public static float2 operator +(float2 _a, float2 _b)
    {
        return new float2(_a.a + _b.a, _a.b + _b.b);
    }
    public static float2 operator -(float2 _a, float2 _b)
    {
        return new float2(_a.a - _b.a, _a.b - _b.b);
    }
    public static float2 operator *(float2 _a, float2 _b)
    {
        return new float2(_a.a * _b.a, _a.b * _b.b);
    }
    public static float2 operator /(float2 _a, float2 _b)
    {
        return new float2(_a.a / _b.a, _a.b / _b.b);
    }

}