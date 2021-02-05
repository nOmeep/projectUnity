using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public CharacterActions _heroesActions;

    public void AttackIsPressed()
    {
        _heroesActions.attack = true;
    }

    public void ShieldIsPressed()
    {
        _heroesActions.block = true;
    }

    public void EvasionIsPressed()
    {
        _heroesActions.evasion = true;
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
