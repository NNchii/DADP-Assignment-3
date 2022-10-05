using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    private LevelManager _lvlMngr;

    // Start is called before the first frame update
    void Start()
    {
        _lvlMngr = GameObject.FindGameObjectWithTag("Level Manager").GetComponent<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Restart()
    {
        _lvlMngr.ReloadScene(_lvlMngr.currentScene);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
