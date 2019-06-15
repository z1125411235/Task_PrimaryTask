using UnityEngine;

namespace UnityChan2D.PCCU{

	[AddComponentMenu("Unity Chan 2D/Player Damaged")]
	public class PlayerDamaged : PlayerAction {
		
		[SerializeField]
		[AnimatorParameter]
		private string damageParameter;

		[SerializeField]
		private Vector2 backwardForce = new Vector2(-4.5f , 5.4f);

		[SerializeField]
		private PassFloat damaged;

		public void Damage(float value){
			
			if(!enabled) return;

			base._rigidbody2D.velocity = new Vector2(transform.right.x * this.backwardForce.x , transform.up.y * this.backwardForce.y);

			base.animator.SetTrigger(this.damageParameter);

			enabled = false;

			this.damaged.Invoke(value);
		}

		void OnDrawGizmosSelected(){


			Gizmos.DrawRay(transform.position , new Vector2( transform.right == Vector3.right ? this.backwardForce.x : -this.backwardForce.x , this.backwardForce.y) / (base._rigidbody2D ? base._rigidbody2D.gravityScale : GetComponent<Rigidbody2D>().gravityScale));
		}
	}
}