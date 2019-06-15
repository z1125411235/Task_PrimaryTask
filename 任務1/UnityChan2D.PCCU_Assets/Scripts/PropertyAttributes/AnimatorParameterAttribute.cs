using UnityEngine;
using System.Collections.Generic;

namespace UnityChan2D.PCCU{
	
	public class AnimatorParameterAttribute : PropertyAttribute {

		public int selected;
		public List<string> parameters = new List<string>();
	}
}