using UnityEngine;
using UnityEngine.Events;

namespace UnityChan2D.PCCU{

	[AddComponentMenu("Unity Chan 2D/Layer Trigger Enter")]
	public class LayerTriggerEnter : MonoBehaviour {

		[SerializeField]
		private LayerMask layer;
		[SerializeField]
		private bool destroy;

		[SerializeField]
		private UnityEvent enter;

		void OnTriggerEnter2D(Collider2D collider){

			if(Utilities.CheckLayer(this.layer , collider.gameObject.layer)){

				this.enter.Invoke();
				if(destroy) Destroy(gameObject);
			}
		}
	}
}