using UnityEngine;
using UnityEditor;

namespace UnityChan2D.PCCU{

	[CustomPropertyDrawer(typeof(SceneMenuAttribute))]
	public class SceneMenuDrawer : PropertyDrawer {

		public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
		{
			SceneMenuAttribute attribute = (SceneMenuAttribute)base.attribute;

			attribute.sceneNames.Clear();

			foreach(EditorBuildSettingsScene scene in EditorBuildSettings.scenes){

				if(scene.enabled) attribute.sceneNames.Add(scene.path.Substring(scene.path.LastIndexOf("/") + 1).Replace(".unity" , string.Empty));
			}

			if(attribute.sceneNames.Count == 0) EditorGUI.PropertyField(position , property);
			else{

				attribute.selected = Mathf.Clamp(attribute.sceneNames.IndexOf(property.stringValue) , 0 , attribute.sceneNames.Count);
				attribute.selected = EditorGUI.Popup(position , label.text , attribute.selected , attribute.sceneNames.ToArray());
				property.stringValue = attribute.sceneNames[attribute.selected];
			}
		}
	}
}