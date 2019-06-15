using UnityEngine;
using UnityEngine.Events;

namespace UnityChan2D.PCCU{
	
	[AddComponentMenu("Unity Chan 2D/Input Key")]
	public class InputKey : MonoBehaviour {

		[SerializeField]
		private KeyCode key;

		[SerializeField]
		private UnityEvent pressed;
		[SerializeField]
		private UnityEvent released;
		[SerializeField]
		private UnityEvent held;

		void Update(){

			if(Input.GetKeyDown(this.key)) this.pressed.Invoke();
			if(Input.GetKeyUp(this.key)) this.released.Invoke();
			if(Input.GetKey(this.key)) this.held.Invoke();
		}
	}
}