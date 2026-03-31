// using System;
// using System.Collections;
// using UnityEngine;
// using UnityEngine.Events;
//
// public class KnockBackFeedBack : MonoBehaviour
// {
//     [SerializeField] private Rigidbody2D rb2d;
//
//     [SerializeField] private float strength = 16, delay = 0.15;
//
//     public UnityEvent OnBegin, OnDone;
//
//     public void PlayFeedback(GameObject sender)
//     {
//         StopAllCoroutines();
//         OnBegin?.Invoke();
//         Vector2 direction = (transform.position - sender.transform.position).normalized;
//         rb2d.AddForce(direction * strength, ForceMode2D.Impulse);
//         StartCoroutine(Reset());
//     }
//     private IEnumerator Reset()
//     {
//         yield return new WaitForSeconds(delay);
//         rb2d.linearVelocity = Vector3.zero;
//         OnDone?.Invoke();
//     }
//
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Start()
//     {
//         
//     }
//
//     // Update is called once per frame
//     void Update()
//     {
//         
//     }
// }
