using UnityEngine;
using UnityEngine.Events;

namespace UnityChan2D.PCCU{

	[AddComponentMenu("Unity Chan 2D/Player Jump")]
	public class PlayerJump : PlayerAction {
		
		[SerializeField]
		[AnimatorParameter]
		private string jumpParameter;

		[SerializeField]
		private float power = 1000;

		[SerializeField]
		private UnityEvent jump;

		public bool Enable{

			set{
				if(base._rigidbody2D) enabled = value;
			}
		}

		public void Jump(){

			if(!enabled) return;

			base._rigidbody2D.AddForce(Vector2.up * this.power);

			base.animator.SetTrigger(this.jumpParameter);

			this.jump.Invoke();
		}
	}
}