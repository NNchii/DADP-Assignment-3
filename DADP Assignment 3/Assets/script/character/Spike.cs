using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public int damageToPlayer = 1;
    
    private GameObject _player;
    private PlayerHealth _playerHealth;
    private PlayerMovement _playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _playerHealth = _player.GetComponent<PlayerHealth>();
        _playerMovement = _player.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject == _player)
        {
            Debug.Log(transform);
            _playerMovement.KnockBack(transform);
            _playerHealth.LooseHealth(damageToPlayer);
        }
        
    }
}
