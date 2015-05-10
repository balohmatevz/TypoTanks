using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

    float progress = 0.0f;
    string[] keys = new string[]{"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",};

    public static GameController gc;
    public static List<string> availKeys = new List<string>();
    public static Dictionary<string, KeyIndicator> key2tank = new Dictionary<string, KeyIndicator>();

	// Use this for initialization
	void Start () {
	    GameController.gc = this;
	}
	
	// Update is called once per frame
	void Update () {
	    progress += Time.deltaTime;
        if(progress > 0.5f){
            progress -= 0.5f;
            GameObject instance = Instantiate(Resources.Load("Tank", typeof(GameObject))) as GameObject;
            instance.transform.position = new Vector3(Random.Range(-2.88f, 2.88f), 0.01f, -6.0f);

        }

        foreach(string s in availKeys){
            if(Input.GetKeyDown(s)){
                availKeys.Remove(s);
                key2tank[s].destroy();
                key2tank.Remove(s);
            }
        }
	}
}
