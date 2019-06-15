using UnityEngine;
using System.Collections;

namespace UnityChan2D.PCCU{

	[AddComponentMenu("Unity Chan 2D/Sound Effect")]
	public class SoundEffect : MonoBehaviour {

		public void PlayLoop(AudioClip clip){

			SoundEffectSource.ins.AudioSource.clip = clip;
			SoundEffectSource.ins.AudioSource.loop = true;
			SoundEffectSource.ins.AudioSource.Play();
		}

		public void Stop(){

			SoundEffectSource.ins.AudioSource.Stop();
		}

		public void PlayOnce(AudioClip clip){

			if(SoundEffectSource.ins) SoundEffectSource.ins.AudioSource.PlayOneShot(clip);
		}
	}
}