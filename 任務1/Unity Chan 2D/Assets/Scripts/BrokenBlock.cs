using UnityEngine;
using UnityEngine.Events;

namespace UnityChan2D.PCCU{

	[AddComponentMenu("Unity Chan 2D/Broken Block")]
	public class BrokenBlock : MonoBehaviour {

		[SerializeField]
		private UnityEvent broken;

		void Start(){

			this.broken.Invoke();
		}

		private void SelfDestroy(){

			Destroy(gameObject);
		}
	}
}