using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntBarrel : MonoBehaviour, IDamagable
{
	public void TakeDamage(float dmg)
	{
		Destroy(gameObject);
	}
}
