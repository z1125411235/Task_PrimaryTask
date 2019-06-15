using UnityEngine;

namespace UnityChan2D.PCCU{

	[AddComponentMenu("Unity Chan 2D/Player Ground")]
	public class PlayerGround : MonoBehaviour {

		[SerializeField]
		private Animator animator;
		[SerializeField]
		[AnimatorParameter]
		private string groundParameter;

		[SerializeField]
		private LayerMask detectLayer;
		[SerializeField]
		private Vector2 detectCenter = new Vector2(0 , -1.5f);
		[SerializeField]
		private Vector2 detectSize = new Vector2(.8f , .1f);

		[SerializeField]
		private PassBool ground;

		void FixedUpdate(){

			bool result = Utilities.OverlapArea(transform.position , this.detectCenter , this.detectSize , this.detectLayer);
			this.ground.Invoke(result);
			this.animator.SetBool(this.groundParameter , result);
		}

		void OnDrawGizmosSelected(){

			Utilities.GizmosOverlapArea(transform.position , this.detectCenter , this.detectSize , Color.green);
		}
	}
}