using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterActions : MonoBehaviour
{
    private Rigidbody2D _knight;
    
    public bool block = false;
    public bool attack = false;
    public bool evasion = false;
    public int health;
    
    // Start is called before the first frame update
    void Start()
    {
        _knight = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
