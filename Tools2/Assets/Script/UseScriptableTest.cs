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
public class UseScriptableTest : MonoBehaviour {
    public ScriptableTest myScriptableObj;
    public string Text;
    public Text textObj;
    public string[] englishW;
    public string[] translated;

	// Use this for initialization
	void Start () {
        textObj = gameObject.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        if(myScriptableObj != null)
        {
            textObj.text = myScriptableObj.GetTranslation(Text);
        }
        

    }
}
