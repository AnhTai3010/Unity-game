using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private Enemy enemyPrefab;
    [SerializeField] private Character _character;
    [SerializeField] float spawnInterval ;
    [SerializeField] Transform[] spawnPoints;

    // [SerializeField] private GameObject enemyPrefab;
    // [SerializeField] private Vector2 minPos;
    // [SerializeField] private Vector2 maxPos;
    // [SerializeField] private float spawnInterval=2f;
    // [SerializeField] private Character _character;
    
    private List<GameObject> enemies = new();

    private int _index;
    
    void Start()
    {
        InvokeRepeating(nameof(SpamwEnemy), 0f, spawnInterval);
    }
    
    // void SpamwEnemy()
    // {
    //     float x = Random.Range(minPos.x, maxPos.x);
    //     float y = Random.Range(minPos.y, maxPos.y);
    //     
    //     Instantiate(enemyPrefab,new Vector2(x,y),Quaternion.identity);
    // }
    
    
    void SpamwEnemy()
    {
        if (spawnPoints == null || spawnPoints.Length == 0) return;
    
        Transform point = spawnPoints[Random.Range(0, spawnPoints.Length)];
        var enemy = Instantiate(enemyPrefab, point.position, Quaternion.identity);
        enemy.SetTarget(_character.transform);
        enemies.Add(enemy.gameObject);
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
        }
    }

    public void DestroyEnemy(GameObject target)
    {
        if (enemies.Count == 0) return;
        Destroy(target);
        enemies.RemoveAt(enemies.IndexOf(target));
    }

    [ContextMenu("DestroyAll")]
    void DestroyEnemies()
    {
        foreach (var t in enemies)
        {
            Destroy(t);
        }

        enemies.Clear();
    }
}