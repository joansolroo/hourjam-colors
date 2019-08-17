using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Price : GameElement
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();
        if (player)
        {
            GameObject.Destroy(this.gameObject); 
        }
    }
}
