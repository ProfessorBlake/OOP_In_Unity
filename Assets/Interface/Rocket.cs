using UnityEngine;

public class Rocket : MonoBehaviour, IDamagable
{
	public void TakeDamage(float dmg)
	{
		GetComponent<Rigidbody>().linearVelocity = Vector3.up * 50;
	}
}