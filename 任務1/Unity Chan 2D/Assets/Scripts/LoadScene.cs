using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityChan2D.PCCU{

	[AddComponentMenu("Unity Chan 2D/Load Scene")]
	public class LoadScene : MonoBehaviour {

		[SerializeField]
		[SceneMenu]
		private string scene;
		[SerializeField]
		private float waitTime = .5f;
		[SerializeField]
		private bool pause;

		private float loadTime;
		private bool loading;

		void Update(){

			if(this.loading && Time.realtimeSinceStartup >= this.loadTime) this.DoLoad();
		}

		public void Load(){

			if(!enabled) return;

			this.loading = true;

			this.loadTime = Time.realtimeSinceStartup + this.waitTime;

			if(this.pause) Time.timeScale = 0;
		}

		private void DoLoad(){

			SceneManager.LoadScene(this.scene);
			Time.timeScale = 1;
		}
	}
}