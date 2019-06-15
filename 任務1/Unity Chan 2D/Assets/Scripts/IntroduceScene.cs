using UnityEngine;
using UnityEngine.Events;
using System.Collections;

namespace UnityChan2D.PCCU{

	[AddComponentMenu("Unity Chan 2D/Introduce Scene")]
	public class IntroduceScene : MonoBehaviour {

		[SerializeField]
		private Transform targetCamera;
		[SerializeField]
		private AudioClip clip;
		[SerializeField]
		private Vector3 targetPosition;

		[SerializeField]
		private UnityEvent begin;
		[SerializeField]
		private UnityEvent end;

		private float processTime;
		private Vector3 startPosition;
		private Vector3 currentPosition;
		private float startPlayTime;

		void Awake(){
			
			if(this.clip) this.processTime = this.clip.length;

			if(!this.targetCamera) this.targetCamera = Camera.main.transform;
			this.startPosition = this.currentPosition = this.targetCamera.position;
		}

		void OnDrawGizmos(){

			if(this.targetCamera){
				Gizmos.color = Color.yellow;
				Gizmos.DrawLine(this.targetCamera.position , this.targetPosition);
				Gizmos.DrawWireSphere(this.targetPosition , .1f);
			}
		}

		public void Begin(){

			this.begin.Invoke();

			this.startPlayTime = Time.time;

			StartCoroutine(this.Process());
		}

		private IEnumerator Process(){

			if(this.processTime == 0){

				this.currentPosition.x = this.targetPosition.x;
				this.currentPosition.y = this.targetPosition.y;
				this.targetCamera.position = this.currentPosition;

			}else{

				float t = 0;

				while(t < 1){

					t = (Time.time - this.startPlayTime) / this.processTime;
					this.currentPosition.x = Mathf.SmoothStep(this.startPosition.x , this.targetPosition.x , t);
					this.currentPosition.y = Mathf.SmoothStep(this.startPosition.y , this.targetPosition.y , t);
					this.targetCamera.position = this.currentPosition;

					yield return null;
				}
			}

			this.end.Invoke();
		}
	}
}