using UnityEngine;
using TMPro;

namespace DefaultNamespace
{
	public class HealthCounter: MonoBehaviour
	{
		[SerializeField] private Wall _wall;
		public TextMeshProUGUI label;
		
		public void Awake()
		{
			label.text = _wall.Health.ToString();
			_wall.OnChanged.AddListener(UpdateLabel);
		}
		public void UpdateLabel()
		{
			label.text = _wall.Health.ToString();
		}
	}
}