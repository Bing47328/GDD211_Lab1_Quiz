using UnityEngine;

/// <summary>
/// Control Puppy 2 by setting parameter values on the animator and using a blend tree to control the motion.
/// This is the type of animation seen in the Lab 1 project folder: "3. Blend Trees".
/// </summary>

public class BlendTree : MonoBehaviour
{
	[SerializeField] private Animator puppy2Animator;
	private float speed;

	private void Update()
	{
		if (Input.GetAxisRaw("Vertical") > 0f) //Walk
		{
			speed = Mathf.Lerp(speed, Input.GetAxisRaw("Vertical") * speed, Time.deltaTime);
		}
		else //Idle
		{
			speed = Mathf.Lerp(speed, 0f, Time.deltaTime * 5f);
		}

		transform.position += new Vector3(Time.deltaTime * 0.32f * speed, 0f);

		puppy2Animator.SetFloat("MoveSpeed", Mathf.Abs(speed));
	}
}
