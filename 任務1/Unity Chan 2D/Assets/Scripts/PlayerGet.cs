using UnityEngine;

namespace UnityChan2D.PCCU{

	[AddComponentMenu("Unity Chan 2D/Player Get")]
	public class PlayerGet : MonoBehaviour {

		[SerializeField]
		private string format = "00";

		[SerializeField]
		private PassString changed;

		private int current;

		public void Get(int value){

			this.current += value;
			this.changed.Invoke(this.current.ToString(this.format));
		}
	}
}