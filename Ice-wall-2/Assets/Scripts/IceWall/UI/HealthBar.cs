using UnityEngine;
using UnityEngine.UI;

namespace IceWall.UI
{
	public class HealthBar: MonoBehaviour
	{
		[SerializeField] private Wall _wall;
		[SerializeField] private Wall _wall2;
		[SerializeField] private Wall _wall3;
		[SerializeField] private Wall _wall4;
		[SerializeField] private LevelManager _levelManager;
		[SerializeField] private Slider _healthSlider;
    
		public void Awake()
		{
			if (_levelManager.CurrentWall == 1f)
			{
				_healthSlider.maxValue = _wall2.Health;
				_healthSlider.value = _wall2.Health;
				_wall2.OnChanged.AddListener(UpdateBar);
			}
			if (_levelManager.CurrentWall == 2f)
			{
				_healthSlider.maxValue = _wall3.Health;
				_healthSlider.value = _wall3.Health;
				_wall3.OnChanged.AddListener(UpdateBar);
			}
			if (_levelManager.CurrentWall == 3f)
			{
				_healthSlider.maxValue = _wall4.Health;
				_healthSlider.value = _wall4.Health;
				_wall4.OnChanged.AddListener(UpdateBar);
			}
			else
			{
				_healthSlider.maxValue = _wall.Health;
				_healthSlider.value = _wall.Health;
				_wall.OnChanged.AddListener(UpdateBar);
			}
		}

		private void UpdateBar()
		{
			if (_levelManager.CurrentWall == 1f)
			{
				_healthSlider.value = _wall2.Health;
			}
			if (_levelManager.CurrentWall == 2f)
			{
				_healthSlider.value = _wall3.Health;
			}
			if (_levelManager.CurrentWall == 3f)
			{
				_healthSlider.value = _wall4.Health;
			}
			else
			{
				_healthSlider.value = _wall.Health;
			}
		}
	}
}