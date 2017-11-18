using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class LibraryController : MonoBehaviour {
    
    public TextAsset library;
    public string fileText;
    public string menuText;

    public string textToUse;
    public string textTranslated;

    public string selectedLang;
    public int langIndex;
    public string[] languages;
    public string[] contents;

	// Use this for initialization
	void OnEnable () {
        char[] separators = { ':', ',' };
        fileText = library.text;

        contents = fileText.Split(separators);
    }
	
	// Update is called once per frame
	void Update () {

        

        //check for issues

        langIndex = -1;
        //search for lang
        for (int i = 0; i < languages.Length; i++)
        {
            if (languages[i] == selectedLang)
            {
                langIndex = i;
            }
        }
        if (langIndex == -1)
        {
            Debug.LogError("The selected language has not been added");
        }

        //search for word
        for (int i = 0; i < contents.Length; i++)
        {
            if (contents[i] == textToUse)
            {
                textTranslated = contents[i + langIndex];
            }
        }
    }

    public string GetTranslation(string text)
    {
        string translation = "NULL";

        //search for word
        for (int i = 0; i < contents.Length; i++)
        {
            if (contents[i] == text)
            {
                translation = contents[i + langIndex];
            }
        }

        return translation;
    }
}
