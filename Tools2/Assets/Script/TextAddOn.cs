using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEditor.Experimental.AssetImporters;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class TextAddOn : MonoBehaviour {

    public LibraryData libraryData;
    public Text textUsed;

	// Use this for initialization
	void Start () {
        GameObject libraryTemp = GameObject.FindGameObjectWithTag("Library");
        libraryData = libraryTemp.GetComponent(typeof(LibraryData)) as LibraryData;
        textUsed = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        textUsed.text = libraryData.words[0];
        
	}
}
