using System.Collections;
using UnityEngine;

namespace IceWall
{
	public class ProjectileExplosion: MonoBehaviour
	{
		public SpriteRenderer _spriteRenderer;
		public Sprite _explosionSprite; 
		
		public void Explode()
		{
			_spriteRenderer.sprite = _explosionSprite;
		}
	}
}