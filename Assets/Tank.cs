using UnityEngine;
using System.Collections;

public class Tank : MonoBehaviour {

    float fireprogress = 0.0f;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if(Vector3.Distance(this.transform.position, Vector3.zero) > 1.25f){
            this.transform.LookAt(Vector3.zero);
	        this.transform.position = Vector3.MoveTowards(this.transform.position, Vector3.zero, 0.01f);
        }else{
            fireprogress += Time.deltaTime;
            if(fireprogress > 1.50f){
                Debug.Log("fire");
                fireprogress -= 1.50f;
            }
        }
	}
}
