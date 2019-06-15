using UnityEngine;

namespace UnityChan2D.PCCU{

	[AddComponentMenu("Unity Chan 2D/Sound Effect Source")]
	[RequireComponent(typeof(AudioSource))]
	public class SoundEffectSource : MonoBehaviour {

		public static SoundEffectSource ins;

		public AudioSource AudioSource{get; private set;}

		void Awake(){
			
			if(ins) Destroy(this);
			else{

				ins = this;

				this.AudioSource = GetComponent<AudioSource>();
			}
		}
	}
}