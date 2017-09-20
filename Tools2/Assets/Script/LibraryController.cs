using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class LibraryController : MonoBehaviour {

    public GameObject menuItem;
    public Text textHolder;
    public TextAsset library;
    public string fileText;
    public string menuText;

	// Use this for initialization
	void OnEnable () {
        fileText = library.text;
        textHolder = menuItem.GetComponent<Text>();
        textHolder.text = fileText;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
