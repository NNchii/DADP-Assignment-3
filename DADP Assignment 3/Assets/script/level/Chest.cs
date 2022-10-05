using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    private GameObject _player;
    public GameObject endScreen;



    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject == _player)
        {
            endScreen.SetActive(true);
            _player.GetComponent<PlayerMovement>().enabled = false;
        }
    }


}
