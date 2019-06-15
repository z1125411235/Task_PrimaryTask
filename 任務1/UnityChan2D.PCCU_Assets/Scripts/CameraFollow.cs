using UnityEngine;
using UnityEngine.Events;
using System.Collections;

namespace UnityChan2D.PCCU{

	[AddComponentMenu("Unity Chan 2D/Camera Follow")]
	public class CameraFollow : MonoBehaviour {

		[SerializeField]
		private Camera followCamera;
		[SerializeField]
		private Transform target;
		[SerializeField]
		private Vector2 endSide = new Vector2(200, 20);

		[SerializeField]
		private UnityEvent begin;
		[SerializeField]
		private UnityEvent end;

		void Awake(){

			this.followCamera = GetComponent<Camera>();
			if(!this.followCamera) this.followCamera = Camera.main;
		}

		void OnDrawGizmos(){

			Utilities.GizmosVerticalLine(transform.position , this.endSide , Color.red);
		}

		public void Begin(){

			this.begin.Invoke();
			StartCoroutine(this.Process());
		}

		public void Stop(){

			StopAllCoroutines();
		}

		private IEnumerator Process(){

			Vector3 right;

			do{
				if(this.followCamera.transform.position.x < this.target.position.x){

					Vector3 cameraPosition = this.followCamera.transform.position;
					this.followCamera.transform.position = new Vector3(this.target.position.x , cameraPosition.y , cameraPosition.z);
				}

				right = this.followCamera.ViewportToWorldPoint(Vector2.right);

				yield return null;
				
			}while(this.endSide.x - right.x > 0);

			this.end.Invoke();
		}
	}
}