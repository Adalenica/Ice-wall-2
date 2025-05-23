using DefaultNamespace;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class HealthSlider : MonoBehaviour
{
	[SerializeField] private Wall _wall;
	[SerializeField] private Wall _wall2;
	[SerializeField] private LevelManager _levelManager;
	
	public Image fillImage; // Assign this in the Inspector
	private float _currentHealth;
	private float _maxHealth;

	public void Awake()
	{
		if (_levelManager.CurrentWall == 1f)
		{
			_maxHealth = _wall2.Health;
			_wall.OnChanged.AddListener(UpdateHealthBar);
		}
		else
		{
			_maxHealth = _wall.Health;
			_wall.OnChanged.AddListener(UpdateHealthBar);
		}
	}

	public void UpdateHealthBar()
	{
		if (_levelManager.CurrentWall == 1f)
		{
			_currentHealth = _wall2.Health;
			float fillAmount = _currentHealth / _maxHealth;
			fillImage.fillAmount = fillAmount;
		}
		else
		{
			_currentHealth = _wall.Health;
			float fillAmount = _currentHealth / _maxHealth;
			fillImage.fillAmount = fillAmount;
		}
	}
}