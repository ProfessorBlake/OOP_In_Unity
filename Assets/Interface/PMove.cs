using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PMove : MonoBehaviour
{
	[SerializeField] private Transform camTransform;

	private void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
	}

	private void Update()
	{
		transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0));
		camTransform.Rotate(new Vector3(-Input.GetAxis("Mouse Y"), 0, 0));

		if (Input.GetMouseButtonDown(0))
		{
			RaycastHit[] hits = Physics.SphereCastAll(camTransform.position, 0.5f, camTransform.forward);
			for (int i = 0; i < hits.Length; i++)
			{
				IDamagable hit = hits[i].transform.GetComponent<IDamagable>();
				if(hit != null)
				{
					hit.TakeDamage(25);
				}
			}
		}

	}

	private void OnDrawGizmos()
	{
		for(int i = 0; i < 1000; i++)
		{
			Gizmos.DrawWireSphere(camTransform.position + camTransform.forward * i * 0.5f, 0.5f);
		}
	}
}
