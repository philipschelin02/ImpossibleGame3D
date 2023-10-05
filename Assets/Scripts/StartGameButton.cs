using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    private void FixedUpdate()
    {

    }

    public void HoverStart()
    {
        transform.localScale = Vector3.one * 1.1f;
    }
    
    public void HoverEnd()
    {
        transform.localScale = Vector3.one;
    }

    public void StartClick()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        mr.material.color = Color.grey;
        mr.material.SetColor(" EmissionColor", Color.grey);
    }

    public void EndClick()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        mr.material.color = Color.white;
        mr.material.SetColor(" EmissionColor", Color.white);
    }

    public void Click()
    {
        SceneManager.LoadScene("GameScene");
    }
}
