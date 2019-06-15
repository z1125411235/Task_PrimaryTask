using UnityEngine;
using System.Collections.Generic;

namespace UnityChan2D.PCCU{
	
	public class SceneMenuAttribute : PropertyAttribute {

		public int selected;
		public List<string> sceneNames = new List<string>();
	}
}