using UnityEngine;
using System.Collections;

/// <summary>
/// Add an Animation Event to Puppy 3's IdleEvents animation.
/// This is the type of animation seen in the Lab 1 project folder: "2. 3D Animation".
/// </summary>

public class AnimationEvent : MonoBehaviour
{
	[SerializeField] private Animator puppy3Animator;
	[SerializeField] private ParticleSystem magicSpellParticleSystem;

	string currentAnim;

	float speed;

	private void Update()
	{
		float input = Input.GetAxisRaw("Vertical");

		//if()

		transform.position += new Vector3(input * speed * Time.deltaTime, 0f);

		PuppyMagicSpell();
	}

	public void PuppyMagicSpell()
	{
		StartCoroutine(Wait());
		magicSpellParticleSystem.Emit(200);
	}

	private void ChangeAnim(string newAnim)
	{
		if (currentAnim == newAnim) return;
		puppy3Animator.Play(newAnim);
		currentAnim = newAnim;
	}

	private IEnumerator Wait()
	{
		yield return new WaitForSeconds(3);
	}
}
