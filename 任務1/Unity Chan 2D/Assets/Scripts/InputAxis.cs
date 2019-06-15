using UnityEngine;
using UnityEngine.Events;

namespace UnityChan2D.PCCU{

	[AddComponentMenu("Unity Chan 2D/Input Axis")]
	public class InputAxis : MonoBehaviour {

		[SerializeField]
		private string axisName;

		[SerializeField]
		private PassFloat value;
		[SerializeField]
		private UnityEvent pressed;
		[SerializeField]
		private UnityEvent released;
		[SerializeField]
		private UnityEvent held;

		void Update(){

			this.value.Invoke(Input.GetAxis(this.axisName));

			if(Input.GetButton(this.axisName)) this.held.Invoke();
			if(Input.GetButtonDown(this.axisName)) this.pressed.Invoke();
			if(Input.GetButtonUp(this.axisName)) this.released.Invoke();
		}
	}
}