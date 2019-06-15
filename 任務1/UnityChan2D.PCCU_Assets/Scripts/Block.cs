using UnityEngine;
using UnityEngine.Events;

namespace UnityChan2D.PCCU{

	[AddComponentMenu("Unity Chan 2D/Block")]
	public class Block : MonoBehaviour {

		[SerializeField]
		private LayerMask playerLayer;
		[SerializeField]
		private Transform brokenBlock ;
		[SerializeField]
		private Vector2 detectCenter = new Vector2(0 , -.8f);
		[SerializeField]
		private Vector2 detectSize = new Vector2(1.4f , .15f);

		[SerializeField]
		private UnityEvent hit;

		void OnCollisionStay2D(Collision2D collision){

			if(Utilities.CheckLayer(this.playerLayer , collision.gameObject.layer)){

				if(Utilities.OverlapArea(transform.position , this.detectCenter , this.detectSize , this.playerLayer)){

					if(this.brokenBlock){

						Object.Instantiate(this.brokenBlock , transform.position , transform.rotation);
						Destroy(gameObject);

					}else this.hit.Invoke();
				}
			}
		}

		void OnDrawGizmosSelected(){

			Utilities.GizmosOverlapArea(transform.position , this.detectCenter , this.detectSize , Color.green);
		}
	}
}