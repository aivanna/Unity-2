using UnityEngine;
using System.Collections;

public class ScriptStar : MonoBehaviour {
	public GameObject Star;
	public GameObject Star2;
	GameObject obj;

	void OnMouseDown(){
		if (GetComponent<SpriteRenderer > ().sprite.name == "star") {
			Spt.rahunok += 3;
		} 
		else {
			Spt.rahunok --;  ///   a--   a++   a+=4
		}
	}
	//float time=0;
	//Vector3 aj = new Vector3 ();
	//obj = (GameObject) Instantiate (Star, new Vector3 (Random.Range (-8f, 8f), Random.Range (-8f, 8f), 0f), new Quaternion (0f, 0f, 0f, 0f));
	// Use this for initialization
	void Start () {
		obj = (GameObject)Instantiate (Star, new Vector3 (Random.Range (-8f, 8f), Random.Range (-8f, 8f), 0f), new Quaternion (0f, 0f, 0f, 0f));
		obj.transform.parent = transform;
		Get Component<SpriteRenderer > ().Sprite
	}
		// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time > 3) {
			int st= Random.Range(1,3);
			if(st == 1){
				Instantiate (Star, new Vector3 (Random.Range (-8f, 8f), Random.Range (-8f, 8f), 0f), new Quaternion (0f, 0f, 0f, 0f));	
			}
			else if(st == 2){
				Instantiate (Star2,new Vector3(Random.Range (-0, 0f), Random.Range (-0f,0f), 0f), new Quaternion(0f,0f,0f,0f));
			}
			time=0;
			obj. transform.position += new Vector3 ();
			if (obj. transform.position.x >= aj.x){

			}
	}
		time += Time.deltaTime;
		if(time >3){
			print("time");

}
}
}