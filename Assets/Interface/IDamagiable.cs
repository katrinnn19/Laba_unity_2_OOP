using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable 
{
    Vector3 Position { get; }
    void Damage(float damage);
}
public class PlayerHealth : MonoBehaviour, IDamageable
{
    public float startingHealth = 100f;
    float m_CurrentHealth;
    Vector3 Position
    {
        get
        {
            return transform.position;
        }
    }

    Vector3 IDamageable.Position => throw new System.NotImplementedException();

    void Start()
    {
        m_CurrentHealth = startingHealth;
    }
    public void Damage(float damage)
    {
        m_CurrentHealth -= damage;
    }
}
