using System;
using UnityEngine;

public class AttackEvent : MonoBehaviour
{
    [SerializeField] private float damage;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Fight_PlayerController>().GetDamage(damage);
        }
    }
}