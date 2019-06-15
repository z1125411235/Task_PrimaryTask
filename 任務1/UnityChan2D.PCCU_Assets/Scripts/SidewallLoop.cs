using UnityEngine;

namespace UnityChan2D.PCCU{

	[AddComponentMenu("Unity Chan 2D/Sidewall Loop")]
	public class SidewallLoop : MonoBehaviour {

		[SerializeField]
		private LayerMask playerLayer;
		[SerializeField]
		private Vector2 loopSide = new Vector2(10 , 20);

		void OnTriggerEnter2D(Collider2D collider){

			if(Utilities.CheckLayer(this.playerLayer , collider.gameObject.layer)){

				Vector3 loopPos = collider.transform.position;
				loopPos.x = this.loopSide.x;
				collider.transform.position = loopPos;
			}
		}

		void OnDrawGizmosSelected(){

			Utilities.GizmosVerticalLine(transform.position , this.loopSide , Color.yellow);
		}
	}
}