using UnityEngine;
using System.Collections;

public class Button_Layout : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.Find ("Button_Surface").GetComponent<Renderer> ().material.color = Color.red;
	}

	// Update is called once per frame
	void Update () {
		GameObject.Find ("Button_Surface").GetComponent<Renderer> ().material.color = Color.red;
	}
}
