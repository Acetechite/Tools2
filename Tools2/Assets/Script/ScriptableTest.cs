using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableTest : ScriptableObject {

    public string objectName = "MyScriptObject";
    public string[] words;
    public string[] languages;
    public string selectedLanguage;
    public int langIndex = -1;

    public string GetTranslation(string eng) {
        for(int i = 0; i<languages.Length; i++)
        {
            if(languages[i] == selectedLanguage)
            {
                langIndex = i;
            }
        }
        if(langIndex == -1)
        {
            return "No Language";
        }
        
        for(int i = 0; i < words.Length; i++)
        {
            string[] allWords = words[i].Split(',');
            if(eng == allWords[0])
            {
                return allWords[langIndex];
            }
        }

        return "word not found";
    }

}
