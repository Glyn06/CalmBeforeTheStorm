using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float health;

    public event EventHandler OnHealthReachZero;

    public void TakeDamage(float damage)
    {
        health -= damage;
    }

    private void Update()
    {
        if (health <= 0)
        {
            OnHealthReachZero?.Invoke(this, EventArgs.Empty);

            Destroy(gameObject);
        }
    }
}
