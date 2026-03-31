using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.UI;
public class HealthManager : MonoBehaviour
{
    [SerializeField]private Image healthBar;
    [SerializeField]private Transform healthTransform;
    [SerializeField]private float healthAmount =100f;
    [SerializeField]private Transform target;
    // [SerializeField] private float speedHeal;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        if (healthAmount <= 0)
        {
            //Application.LoadLevel(Application.loadedLevel);
        }
        if (Keyboard.current.backspaceKey.isPressed)
        {
            TakeDamage(20);
        }

        if (Keyboard.current.spaceKey.isPressed)
        {
            Heal(5);
        }

        var pos=Camera.main.WorldToScreenPoint(target.position);
        healthTransform.transform.position=pos;
    }

    // public void setTarget(Transform target) => _target = target;

    public void TakeDamage(float damage)
    {
        healthAmount -= damage;
        healthBar.fillAmount = healthAmount / 100f;
    }

    public void Heal(float healingAmount)
    {
        healthAmount += healingAmount;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);
        
    }
}