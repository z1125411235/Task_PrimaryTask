using UnityEngine;
using System.Collections;

namespace UnityChan2D.PCCU{
	
	public abstract class PlayerAction : MonoBehaviour {

		[SerializeField]
		protected Animator animator;

		protected Rigidbody2D _rigidbody2D;

		protected virtual void Awake(){

			this._rigidbody2D = GetComponent<Rigidbody2D>();
			enabled = this._rigidbody2D;
		}
	}
}