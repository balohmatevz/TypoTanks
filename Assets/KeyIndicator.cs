using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class KeyIndicator : MonoBehaviour {

    string key = "";

    string[] keys = new string[]{"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",};

	// Use this for initialization
	void Start () {
	    key = keys[Random.Range(0,25)];
        try{
            Debug.Log(key);
            GameController.availKeys.Add(key);
            GameController.key2tank.Add(key, this);
            Text t = this.transform.parent.gameObject.GetComponentInChildren<Text>();
            t.text = key;
        }catch{
            this.destroy();
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void destroy(){
        Destroy(this.transform.parent.gameObject);
    }
}
