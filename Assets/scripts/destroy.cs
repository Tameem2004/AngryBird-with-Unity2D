using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject pig;
    public GameObject Pattern;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag=="Ground")
        {
            Destroy();
        }
        // else if(collision.collider.tag=="Rock")
        // {
        //     Destroy();
        // }
    }

    private void Destroy()
    {
        Destroy(pig);
        Instantiate(Pattern,transform.position,Quaternion.identity);
    }
}
