using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEditor.Experimental.AssetImporters;
using UnityEngine;

public class MyArray
{
    public string[] array = new string[0];
}

[ScriptedImporter(1,"lang")]
public class LangImporter : ScriptedImporter {


    public GameObject library;
    public LibraryData libraryData;
    public string text;
    public string menuText;

    public string textToUse;
    public string textTranslated;
    
    public int langIndex;

    [SerializeField]
    string[] m_languages;

    [SerializeField]
    string[] m_contents;

    [SerializeField]
    string m_selectedLang;

    [SerializeField]
    string m_textToUse;

    [SerializeField]
    string m_textTranslated;

    [SerializeField]
    string[] m_words;

    [SerializeField]
    string m_test="hello";

    public override void OnImportAsset(AssetImportContext ctx)
    {
        //Main asset
        var lang = new ScriptableObject();
        ctx.SetMainAsset("MainAsset", lang);

        //Material as sub-asset
        text = File.ReadAllText(ctx.assetPath, Encoding.UTF8);
        char[] separators = { ':' };

        m_contents = text.Split(separators);
        m_languages = m_contents[1].Split(',');

        int langCnt = m_languages.Length;

        int lineCnt = 0;
        for(int i = 0; i < m_contents.Length; i++)
        {
            if(m_contents[i] == "\r\n")
            {
                lineCnt++;
            }
        }

        m_words = new string[lineCnt];
        for(int i = 0, k = 2; i < m_words.Length; k++)
        {
            if(m_contents[k] != "\r\n")
            {
                m_words[i] = m_contents[k];
                i++;
            }
        }

        library = GameObject.FindGameObjectWithTag("Library");
        libraryData = library.GetComponent(typeof(LibraryData)) as LibraryData;
        libraryData.setWords(m_words);
        libraryData.setLanguages(m_languages);

    }
    void OnEnable() {
        
    }
}
