using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{
    IEnumerator OnCollisionEnter(Collision other)
    { 
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("WinScene");
    }
}