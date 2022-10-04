using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterCheckpoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<PlayerHealth>().SetCheckPoint(gameObject.transform.position);
        Debug.Log(gameObject.transform.position);
    }
}