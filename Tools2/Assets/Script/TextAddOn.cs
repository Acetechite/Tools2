using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAddOn : MonoBehaviour {

    public GameObject libraryTester;
    public LibraryController library;
    public string englishText;
    public string translatedText;
    public Text textUsed;

	// Use this for initialization
	void Start () {
        library = libraryTester.GetComponent<LibraryController>();
        textUsed = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        translatedText = library.GetTranslation(englishText);
        textUsed.text = translatedText;
	}
}
