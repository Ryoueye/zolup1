using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {
    private readonly Vector3 vec_LeftLimit = new Vector3(-73.1f, 6.43f, -47.39f);
    private readonly Vector3 vec_RightLimit = new Vector3(-60.77f, 6.43f, -47.39f);
    

    private Vector3 initPos;
    private Vector3 moveDirection;
    private float deltaTime;

    private float speed;
    
    void Awake()
    {
        this.transform.localPosition = initPos;

        speed = 5.0f;
    }

    void Enable()
    {

    }

	
	void Start () {
		
	}
	
	
	void Update () {
      
      

        moveDirection = Vector3.left * Time.deltaTime * speed;
        this.transform.localPosition += moveDirection;

        if (this.transform.localPosition.x <= vec_LeftLimit.x)
        {
            this.transform.localPosition = vec_LeftLimit;
            speed *= -1; 
        }
        else if (this.transform.localPosition.x >= vec_RightLimit.x)
        {
            this.transform.localPosition = vec_RightLimit;
            speed *= -1; 
        }
	}
}
