using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace IceWall.UI
{
	public class HealthCounter: MonoBehaviour
	{
		[SerializeField] private Wall[] _walls;
		[SerializeField] private LevelManager _levelManager;
		public TextMeshProUGUI label;
		
		public void SetUp()
		{
			var index = _levelManager.CurrentWall;
			label.text = _walls[index].Health.ToString();
			_walls[index].OnChanged.AddListener(UpdateLabel);
		}
		
		public void UpdateLabel()
		{
			label.text = _walls[_levelManager.CurrentWall].Health.ToString();
		}
	}
}