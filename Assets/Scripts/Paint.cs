﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paint : GameElement
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();
        if (player)
        {
            player.color = this.color;
        }
    }
}
