using UnityEngine;
using System.Collections;

public class Animations : MonoBehaviour {
    private Animator anim;
	public float WalkIdle;
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	
	void Update () {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {

            WalkIdle = 1;

        }
        else {

            WalkIdle = 0;
            
        }

        anim.SetFloat("Idle_walk",WalkIdle);
	}

    

}
