using System.Collections.Generic;
using UnityEngine;

public abstract class Equipment
{
	public abstract void Use();
}

public abstract class Weapon : Equipment
{
	public float Damage;
}

public abstract class RangedWeapon : Weapon
{
	public float Range;
}

public class Bow : RangedWeapon
{
	public override void Use()
	{
		//Creates an arrow
		//Applies a force
		//Plays sound
	}
}

public class Catapult : RangedWeapon
{
	public override void Use()
	{
		//Spawn big rock
		//Add force to rock
		//Play sound
	}
}

public class Potion : Equipment
{
	public override void Use()
	{
		//Increase health
	}
}

public class Player : MonoBehaviour
{
	public List<Equipment> EquipmentList = new List<Equipment>();

	private void Start()
	{
		EquipmentList.Add(new Catapult());
		EquipmentList.Add(new Bow());
		EquipmentList.Add(new Potion());
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			EquipmentList[0].Use();
		}
		if (Input.GetMouseButtonDown(1))
		{
			EquipmentList[1].Use();
		}
	}
}