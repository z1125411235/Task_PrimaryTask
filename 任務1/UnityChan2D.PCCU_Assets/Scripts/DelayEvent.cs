using UnityEngine;
using UnityEngine.Events;

namespace UnityChan2D.PCCU{

	[AddComponentMenu("Unity Chan 2D/Delay Event")]
	public class DelayEvent : MonoBehaviour {

		[SerializeField]
		private float delayTime;
		[SerializeField]
		private bool autoProcess;

		[SerializeField]
		private UnityEvent process;

		void Start(){

			if(this.autoProcess) this.Process();
		}

		public void Process(){

			Invoke("InvokeEvent" , this.delayTime);
		}

		private void InvokeEvent(){

			this.process.Invoke();
		}
	}
}