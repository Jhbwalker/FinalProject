using UnityEngine;
using System.Collections;

public class BaseItem : MonoBehaviour {
	private string itemName; 
	private string itemDescription; 
	private int itemID; 

	public enum ItemTypes{ 

		Potions, 
		Weapons, 
		Scrolls, 
		Chest
	}

	private ItemTypes itemType; 

	public string ItemName { 
		get {
			return itemName; 
		} 
		set { 
			itemName = value; 
		}  

	}
	public string ItemDescriptions { 
		get {
			return itemDescription; 
		} 
		set { 
			itemDescription = value; 
		}  
		
	}
	public int ItemID { 
		get {
			return itemID; 
		} 
		set { 
			itemID = value; 
		}  
		
	}

	public ItemTypes ItemType{ 
		get{ 
			return itemType; 
		}
		set{ 
			itemType = value; 
		} 
	}




}
