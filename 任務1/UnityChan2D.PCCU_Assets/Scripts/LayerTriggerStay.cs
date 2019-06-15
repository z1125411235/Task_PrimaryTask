using UnityEngine;
using UnityEngine.Events;

namespace UnityChan2D.PCCU{

	[AddComponentMenu("Unity Chan 2D/Layer Trigger Stay")]
	public class LayerTriggerStay : MonoBehaviour {

		[SerializeField]
		private LayerMask layer;

		[SerializeField]
		private UnityEvent stay;

		void OnTriggerStay2D(Collider2D collider){

			if(Utilities.CheckLayer(this.layer , collider.gameObject.layer)){

				this.stay.Invoke();
			}
		}
	}
}