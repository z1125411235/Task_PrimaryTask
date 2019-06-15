using UnityEngine;
using UnityEditor;

namespace UnityChan2D.PCCU{
	
	[CustomPropertyDrawer(typeof(AnimatorParameterAttribute))]
	public class AnimatorParameterDrawer : PropertyDrawer {
		
		public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
		{
			AnimatorParameterAttribute attribute = (AnimatorParameterAttribute)base.attribute;
			SerializedProperty animatorProperty = property.serializedObject.FindProperty("animator");

			if(animatorProperty == null) EditorGUI.LabelField(position , label.text , "-");
			else{

				Animator animator = (Animator)animatorProperty.objectReferenceValue;

				if(animator){

					attribute.parameters.Clear();

					if(animator.gameObject.activeSelf){
						
						foreach(AnimatorControllerParameter parameter in animator.parameters){
							
							attribute.parameters.Add(parameter.name);
						}
					}

					if(attribute.parameters.Count == 0) EditorGUI.LabelField(position , label.text , "-");
					else{
						
						attribute.selected = Mathf.Clamp(attribute.parameters.IndexOf(property.stringValue) , 0 , attribute.parameters.Count);

						attribute.selected = EditorGUI.Popup(position , property.displayName , attribute.selected , attribute.parameters.ToArray());
						property.stringValue = attribute.parameters[attribute.selected];
					}

				}else{

					animator = ((Component)animatorProperty.serializedObject.targetObject).GetComponent<Animator>();

					if(animator) animatorProperty.objectReferenceValue = animator;
					else EditorGUI.LabelField(position , label.text , "-");
				}
			}
		}
	}
}