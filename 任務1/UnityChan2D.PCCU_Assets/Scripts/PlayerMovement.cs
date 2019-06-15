using UnityEngine;

namespace UnityChan2D.PCCU{

	[AddComponentMenu("Unity Chan 2D/Player Movement")]
	public class PlayerMovement : PlayerAction {
		
		[SerializeField]
		[AnimatorParameter]
		private string horizontalParameter;
		[SerializeField]
		[AnimatorParameter]
		private string verticalParameter;

		[SerializeField]
		private float speed = 10;

		public float Horizontal{ set; private get;}

		void Update(){

			if(Mathf.Abs(this.Horizontal) > 0){

				Vector3 euler = transform.eulerAngles;
				transform.rotation = Quaternion.Euler(euler.x , Mathf.Sign(this.Horizontal) == 1 ? 0 : 180 , euler.z);
			}

			base._rigidbody2D.velocity = new Vector2(this.Horizontal * this.speed , base._rigidbody2D.velocity.y);

			base.animator.SetFloat(this.horizontalParameter , this.Horizontal);
			base.animator.SetFloat(this.verticalParameter , base._rigidbody2D.velocity.y);
		}
	}
}