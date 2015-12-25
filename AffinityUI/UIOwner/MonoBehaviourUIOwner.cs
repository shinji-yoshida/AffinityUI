using UnityEngine;

namespace AffinityUI
{
	public class MonoBehaviourUIOwner : UIOwner {
		MonoBehaviour owner;
		
		public MonoBehaviourUIOwner (MonoBehaviour owner) {
			this.owner = owner;
		}
		
		public override bool IsMonoBehaviour {
			get {
				return true;
			}
		}
		
		public override GameObject GameObject {
			get {
				return owner.gameObject;
			}
		}
	}
}
