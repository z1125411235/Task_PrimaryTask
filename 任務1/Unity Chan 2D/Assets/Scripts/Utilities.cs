using UnityEngine;

namespace UnityChan2D.PCCU{
	
	public class Utilities{

		public static Collider2D OverlapArea(Vector2 source , Vector2 center , Vector2 size , LayerMask layerMask){

			Vector2 radius = size / 2;
			Vector2 pointA = new Vector2(center.x - radius.x , center.y - radius.y) + source;
			Vector2 pointB = new Vector2(center.x + radius.x , center.y + radius.y) + source;
			return Physics2D.OverlapArea(pointA , pointB , layerMask);
		}

		public static void GizmosOverlapArea(Vector2 source , Vector2 center , Vector2 size , Color color){

			Gizmos.color = color;
			Gizmos.DrawWireCube(source + center , size);
		}

		public static void GizmosVerticalLine(Vector3 source , Vector3 target , Color color){

			Gizmos.color = color;

			float height = Mathf.Abs(target.y) / 2;
			Gizmos.DrawLine(new Vector2(target.x , source.y - height) , new Vector2(target.x , source.y + height));
		}

		public static bool CheckLayer(LayerMask layer , int value){

			return (layer >> value & 1) == 1;
		}
	}
}