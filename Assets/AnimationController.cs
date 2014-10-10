using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour
{
	public Animation[] anims;
	private float  next;
	private string animName;
	private bool running = false;
	private string current;
	//private float time;
	// Use this for initialization
	void Start ()
	{
		current = "fly";
		//time = 0;
	}

	// Update is called once per frame
	void Update ()
	{
		if ( Input.GetButtonDown("Fire1") ) {
			//animation["fly_breath"].blendMode =  AnimationBlendMode.Additive;
			animation.Play("fly_breath");
			animation.PlayQueued(current);
			current = "fly_breath";
		}
		
		if ( Input.GetButtonDown("Fire2") ) {
			animation.Play("fly_attack");
			animation.PlayQueued(current);
			current = "fly_attack";
		}

		if(Input.GetKeyDown(KeyCode.LeftShift))
	   	{
			if(running == false){
				running = true;
				animation.Play("swoop");
				current = "swoop";
			}
		}

		if(Input.GetKeyUp(KeyCode.LeftShift))
		{
			if(running == true){
				running = false;
				animation.Play("fly");
				current = "fly";
			}
		}
	}
}

