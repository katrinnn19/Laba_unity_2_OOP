using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerH : MonoBehaviour
{
    [SerializeReference]
    public IDamageable shield = new ProtonShield();
}
public class ProtonShield : IDamageable
{
    public float hitPoints = 10f;
    public Vector3 Position { get; }
    public void Damage(float damage)
    {
        hitPoints -= damage;
    }
}
