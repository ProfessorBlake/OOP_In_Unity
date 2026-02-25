using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Encapsulation
{
	/// <summary>
	/// This button should mute a TV
	/// </summary>
	[RequireComponent(typeof(Collider))]
	public class Mute : MonoBehaviour
	{
		[SerializeField] private TV tv;

		private void OnMouseDown()
		{
			tv.ToggleVolume();
		}
	}
}