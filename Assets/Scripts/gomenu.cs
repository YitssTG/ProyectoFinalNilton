using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gomenu : MonoBehaviour
{
    public string menuscene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene(menuscene);
    }
}
