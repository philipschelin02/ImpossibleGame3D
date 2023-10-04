using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    IEnumerator OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
}
