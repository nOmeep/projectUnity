using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterActions : MonoBehaviour
{
    private Rigidbody2D _knight;
    
    public bool block = false;
    public bool attack = false;
    public bool evasion = false;
    
    public int health = 3;

    public float jumpForce = 5.0f;
    
    void Start()
    {
        _knight = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (evasion == true && Mathf.Approximately(_knight.velocity.y, 0))
        {
            evasion = false;
            _knight.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
