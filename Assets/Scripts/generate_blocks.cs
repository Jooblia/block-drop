using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generate_blocks : MonoBehaviour
{
    float timer = -1;
    Vector2 objPos;
    public GameObject block;

    void Start()
    {
        objPos = new Vector2(0, 0);
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(block, objPos, Quaternion.identity);
            objPos = new Vector2(objPos.x, this.transform.position.y);
            timer = 1;
        }
    }
}
