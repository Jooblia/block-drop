using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block_physics : MonoBehaviour
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
        // when the block collides with something, destroy it.
        Destroy(this.gameObject);
    }
}
