// using UnityEngine;
// using UnityEngine.Rendering;
//
// public class NewMonoBehaviourScript : MonoBehaviour
// {
//     [SerializeField] private int maxHP = 100;
//     [SerializeField] private int currentHP;
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Start()
//     {
//         currentHP = maxHP;
//     }
//
//     public void TakeDamage(int damage)
//     {
//         currentHP -= damage;
//         currentHP = Mathf.Clamp(currentHP, 0, maxHP);
//         if (currentHP <= 0)
//         {
//             Destroy(gameObject);
//         }
//     }
//
//     void Die()
//     {
//         Debug.Log("Die");
//         gameObject.SetActive(false);
//     }
//     // Update is called once per frame
//     void Update()
//     {
//         
//     }
// }
