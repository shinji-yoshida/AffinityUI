using UnityEngine;

namespace AffinityUI
{
	public abstract class UIOwner {
		public abstract bool IsMonoBehaviour {get;}
		public abstract GameObject GameObject {get;}
	}
}
