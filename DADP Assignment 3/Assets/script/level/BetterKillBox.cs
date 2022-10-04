using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterKillBox : MonoBehaviour
{

    private GameObject _player;
    private LevelManager _lvlMngr;

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _lvlMngr = GameObject.FindGameObjectWithTag("Level Manager").GetComponent<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        
        if(col.gameObject == _player)
        {
            _player.GetComponent<PlayerHealth>().Die();
            //_lvlMngr.ReloadScene(_lvlMngr.currentScene);
        }
    }
}
