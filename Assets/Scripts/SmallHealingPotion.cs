﻿using UnityEngine;

public class SmallHealingPotion : InventoryItem
{

    public int healingRecovery;
    private Player player;

    void Awake()
    {
       //FindPlayer();
    }

    public void Start(){
        FindPlayer();
    }

    private void FindPlayer()
    {
        player = FindObjectOfType<Player>();
        if (player == null)
        {
            Debug.LogError("Player not found");
            this.enabled = false;
        }
    }

    public override void Purchase()
    {
        player.lifePotions.Enqueue(this);
    }


    public void UseItem()
    {
        player.health += healingRecovery;
    }

}
