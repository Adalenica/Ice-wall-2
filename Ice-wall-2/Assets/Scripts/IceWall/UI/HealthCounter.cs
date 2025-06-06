using TMPro;
using UnityEngine;

namespace IceWall.UI
{
	public class HealthCounter: MonoBehaviour
	{
		[SerializeField] private Wall _wall;
		[SerializeField] private Wall _wall2;
		[SerializeField] private LevelManager _levelManager;
		public TextMeshProUGUI label;
		
		public void Awake()
		{
			if (_levelManager.CurrentWall == 1f)
			{
				label.text = _wall2.Health.ToString();
				_wall2.OnChanged.AddListener(UpdateLabel);
			}
			else
			{
				label.text = _wall.Health.ToString();
				_wall.OnChanged.AddListener(UpdateLabel);
			}
		}
		public void UpdateLabel()
		{
			if (_levelManager.CurrentWall == 1f)
			{
				label.text = _wall2.Health.ToString();
			}
			else
			{
				label.text = _wall.Health.ToString();
			}
		}
	}
}