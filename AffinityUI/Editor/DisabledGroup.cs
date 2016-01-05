using UnityEngine;
using UnityEditor;

namespace AffinityUI {
	public class DisabledGroup : Composite<DisabledGroup> {
		BindableProperty<DisabledGroup, bool> isDisabled;

		public DisabledGroup() {
			isDisabled = new BindableProperty<DisabledGroup, bool>(this);
		}

		public DisabledGroup OnDisabled(PropertyChangedEventHandler<DisabledGroup, bool> handler) {
			isDisabled.PropertyChanged += handler;
			return this;
		}

		public BindableProperty<DisabledGroup, bool> IsDisabled() {
			return isDisabled;
		}

		public DisabledGroup IsDisabled(bool value) {
			isDisabled.Value = value;
			return this;
		}

		protected override void OnBeginLayout_GUI () {
			EditorGUI.BeginDisabledGroup(isDisabled);
		}

		protected override void OnEndLayout_GUI () {
			EditorGUI.EndDisabledGroup();
		}

		protected override void OnBeginLayout_GUILayout () {
			EditorGUI.BeginDisabledGroup(isDisabled);
		}

		protected override void OnEndLayout_GUILayout () {
			EditorGUI.EndDisabledGroup();
		}
	}
}
