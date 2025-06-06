using UnityEngine;
using UnityEngine.UI;

namespace IceWall.UI
{
	public class HealthBar: MonoBehaviour
	{
		[SerializeField] private Wall[] _walls;
		[SerializeField] private LevelManager _levelManager;
		[SerializeField] private Slider _healthSlider;
    
		public void SetUp()
		{
			var index = _levelManager.CurrentWall;
			_healthSlider.maxValue = _walls[index].Health;
			_healthSlider.value = _walls[index].Health;
			_walls[index].OnChanged.AddListener(UpdateBar);
		}

		private void OnDestroy()
		{
			foreach (var wall in _walls)
			{
				wall.OnChanged.RemoveListener(UpdateBar);
			}
		}

		private void UpdateBar()
		{
			_healthSlider.value = _walls[_levelManager.CurrentWall].Health;
		}
	}
}