using System.Collections;
using UnityEngine;

namespace IceWall
{
	public class ProjectileExplosion: MonoBehaviour
	{
		public SpriteRenderer _spriteRenderer;
		public SpriteRenderer _explosionRenderer;
		public Animator _animator;
		
		public void Explode()
		{
			_spriteRenderer.enabled = false;
			_explosionRenderer.enabled = true;
			_animator.enabled = true;
		}
	}
}