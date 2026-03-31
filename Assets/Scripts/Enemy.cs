using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform _target;

    [SerializeField] private float SpeedEnemy; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void SetTarget(Transform target)=>_target=target;
    // Update is called once per frame
    void Update()
    {
        transform.position=Vector3.MoveTowards(transform.position,_target.position, SpeedEnemy * Time.deltaTime);
    }
}
