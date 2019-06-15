using UnityEngine;
using UnityEngine.Events;
using System.Collections;

namespace UnityChan2D.PCCU{

	[AddComponentMenu("Unity Chan 2D/Player Invincible")]
	public class PlayerInvincible : PlayerAction {

		[SerializeField]
		[AnimatorParameter]
		private string invincibleParameter;

		[SerializeField]
		private float duration = 1;

		[SerializeField]
		private UnityEvent begin;
		[SerializeField]
		private UnityEvent end;

		private readonly float delay = .2f;

		protected override void Awake ()
		{
			enabled = false;
		}

		public void Invincible(){

			StartCoroutine(this.DoInvincible());
		}

		private IEnumerator DoInvincible(){

			yield return new WaitForSeconds(this.delay);

			while(!enabled) yield return new WaitForFixedUpdate();

			this.begin.Invoke();
			base.animator.SetBool(this.invincibleParameter , true);

			yield return new WaitForSeconds(this.duration);

			this.end.Invoke();
			base.animator.SetBool(this.invincibleParameter , false);

			enabled = false;
		}
	}
}