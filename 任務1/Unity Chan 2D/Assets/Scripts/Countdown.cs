using UnityEngine;
using UnityEngine.Events;

namespace UnityChan2D.PCCU{

	[AddComponentMenu("Unity Chan 2D/Countdown")]
	public class Countdown : MonoBehaviour {

		[SerializeField]
		private int time = 300;

		[SerializeField]
		private PassString init;
		[SerializeField]
		private PassString changed;
		[SerializeField]
		private UnityEvent end;

		private int remaining;

		void Start(){

			this.remaining = this.time;
			this.init.Invoke(this.time.ToString());
		}
		public void Begin(){
			
			InvokeRepeating("DoCountdown" , 1 , 1);
			Invoke("End" , this.time);
		}

		public void Stop(){

			CancelInvoke();
		}

		private void DoCountdown(){

			this.remaining = Mathf.Clamp(this.remaining - 1 , 0 , this.time);
			this.changed.Invoke(this.remaining.ToString());
		}

		private void End(){

			this.end.Invoke();
			enabled = false;
		}
	}
}