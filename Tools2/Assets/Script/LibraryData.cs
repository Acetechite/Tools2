using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibraryData : MonoBehaviour {

    public string selectedLanguage;
    public string[] languages;
    public string[] words;
    

    public void setWords(string[] w) {
        words = w;
    }
    public void setLanguages(string[] l)
    {
        languages = l;
    }
}
