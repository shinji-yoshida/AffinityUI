using UnityEngine;

namespace AffinityUI
{
	public class EditorWindowUIOwner : UIOwner {
		public override bool IsMonoBehaviour {
			get {
				return false;
			}
		}
		
		public override GameObject GameObject {
			get {
				throw new System.Exception("EditorWindow has no gameObject");
			}
		}
	}
}
