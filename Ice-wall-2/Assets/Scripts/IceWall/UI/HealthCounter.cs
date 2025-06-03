using TMPro;
using UnityEngine;

namespace IceWall.UI
{
	public class HealthCounter: MonoBehaviour
	{
		[SerializeField] private Wall _wall;
		[SerializeField] private Wall _wall2;
		[SerializeField] private Wall _wall3;
		[SerializeField] private Wall _wall4;
		[SerializeField] private LevelManager _levelManager;
		public TextMeshProUGUI label;
		
		public void Awake()
		{
			if (_levelManager.CurrentWall == 1f)
			{
				label.text = _wall2.Health.ToString();
				_wall2.OnChanged.AddListener(UpdateLabel);
			}
			if (_levelManager.CurrentWall == 2f)
			{
				label.text = _wall3.Health.ToString();
				_wall3.OnChanged.AddListener(UpdateLabel);
			}
			if (_levelManager.CurrentWall == 3f)
			{
				label.text = _wall4.Health.ToString();
				_wall4.OnChanged.AddListener(UpdateLabel);
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
			if (_levelManager.CurrentWall == 2f)
			{
				label.text = _wall3.Health.ToString();
			}
			if (_levelManager.CurrentWall == 3f)
			{
				label.text = _wall4.Health.ToString();
			}
			else
			{
				label.text = _wall.Health.ToString();
			}
		}
	}
}