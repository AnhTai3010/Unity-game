using System;
using UnityEngine;

public class Sword : MonoBehaviour
{
    [SerializeField] private  SpawnEnemy spawnEnemy;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.forward * Time.deltaTime * 50f);
    }

    /*private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.gameObject.name);
    }*/
    private void OnTriggerEnter2D(Collider2D other)
    {
        spawnEnemy.DestroyEnemy(other.gameObject);
    }
}
