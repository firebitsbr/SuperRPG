﻿using UnityEngine;
using System.Collections.Generic;

public class Shop {
	
	private List<Item> itens = new List<Item>();

	public Shop(){
		itens.Add(new WoodenSword());
		itens.Add(new WoodenShield());
	}

	public void putItem(Item item){
		itens.Add(item);
	}

	public List<Item> ItensToSell{
		get{ 
			return itens;
		}
	}

	public Item BuyItem(string name){
		foreach (Item item in itens)
			if (name.Equals (item.Name ())) {
				itens.Remove (item);
				return item;			
			}
		return null;
	}

}
