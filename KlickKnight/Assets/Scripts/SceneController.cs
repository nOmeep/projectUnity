using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AttackIsPressed()
    {
        Debug.Log("Attack");
    }

    public void ShieldIsPressed()
    {
        Debug.Log("Shield");
    }

    public void EvasionIsPressed()
    {
        Debug.Log("Evasion");
    }

    public void Pause()
    {
        Debug.Log("Its paused");
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
