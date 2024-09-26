using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void start()
    {
        SceneManager.LoadScene("Fase");
    }
    public void quit()
    {
        Application.Quit();
        Debug.Log("Você saiu");
    }
}
