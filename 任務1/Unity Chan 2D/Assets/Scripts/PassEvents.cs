using UnityEngine;
using UnityEngine.Events;

namespace UnityChan2D.PCCU{

	[System.Serializable] public class PassBool : UnityEvent<bool>{}
	[System.Serializable] public class PassFloat : UnityEvent<float>{}
	[System.Serializable] public class PassString : UnityEvent<string>{}
}