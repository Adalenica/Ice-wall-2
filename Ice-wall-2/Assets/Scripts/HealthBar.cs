using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;
namespace DefaultNamespace
{
	public class HealthBar: MonoBehaviour
	{
		[SerializeField] private Wall _wall;
		[SerializeField] private Wall _wall2;
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
			else
			{
				_healthSlider.value = _wall.Health;
			}
		}
	}
}