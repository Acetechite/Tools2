using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.AssetImporters;
using UnityEditor.SceneManagement;
using UnityEngine;


[CustomEditor(typeof(LangImporter))]
public class LangImporterEditor : ScriptedImporterEditor {

    public override void OnInspectorGUI()
    {
        var selectedLang = new GUIContent("Selected Lang");
        var selectedLangP = serializedObject.FindProperty("m_selectedLang");

        var languages = new GUIContent("Languages");
        var languagesP = serializedObject.FindProperty("m_languages");

        var words = new GUIContent("Words");
        var wordsP = serializedObject.FindProperty("m_words");


        EditorGUILayout.PropertyField(selectedLangP, selectedLang);

        EditorGUI.BeginChangeCheck();
        EditorGUILayout.PropertyField(languagesP, true);
        if (EditorGUI.EndChangeCheck())
            serializedObject.ApplyModifiedProperties();

        EditorGUI.BeginChangeCheck();
        EditorGUILayout.PropertyField(wordsP, true);
        if (EditorGUI.EndChangeCheck())
            serializedObject.ApplyModifiedProperties();

        EditorGUIUtility.LookLikeControls();

        base.ApplyRevertGUI();
    }
}
