using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Control : MonoBehaviour {

    private Animation animation;
    private bool moving = false;


	// Use this for initialization
	void Start () {
        animation = GetComponent<Animation>();
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * (transform.localScale.x * .05f));

	}

    public void Walk()
    {
        if (!animation.isPlaying)
        {
            animation.Play();
            moving = true;


        }
        else
        {
            animation.Stop();
            moving = false;
        }
    }

    public void LookAt()
    {
        transform.LookAt(Camera.main.transform.position);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

    }

    public void Bigger()
    {
        transform.localScale += new Vector3(1, 1, 1);
    }


    public void Smaller()
    {
        transform.localScale -= new Vector3(1, 1, 1);
    }


}
