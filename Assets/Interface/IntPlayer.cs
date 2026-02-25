using UnityEngine;

public class IntPlayer : MonoBehaviour, IDamagable
{
	private float health;

	public void TakeDamage(float dmg)
	{
		health -= dmg;
		Debug.Log(health);
	}
}
