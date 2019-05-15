using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Śmierć : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Bullet(Clone)")
        {
            Destroy(this);
        }
    }
}
