using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterActions : MonoBehaviour
{
    public Rigidbody2D _knight;
    
    public bool block = false;
    public bool attack = false;
    
    public int health = 3;

    public float jumpForce = 5.0f;
    
    void Start()
    {
        _knight = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
    
    }
}
