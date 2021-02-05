using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public CharacterActions _heroesActions;

    // Start is called before the first frame update
    void Start()
    {
       // _heroesActions = GetComponent<CharacterActions>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AttackIsPressed()
    {
        _heroesActions.attack = true;
        Debug.Log("Attack is " + _heroesActions.attack);
    }

    public void ShieldIsPressed()
    {
        _heroesActions.block = true;
        Debug.Log("Shield " + _heroesActions.block);
    }

    public void EvasionIsPressed()
    {
        _heroesActions.evasion = true;
        Debug.Log("Evasion " + _heroesActions.evasion);
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
