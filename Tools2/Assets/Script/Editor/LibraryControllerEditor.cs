using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LibraryController))]
public class LibraryControllerEditor : Editor {

    SerializedProperty library;
    SerializedProperty selectedLang;

    SerializedProperty languages;

    void OnEnable() {
        library = serializedObject.FindProperty("library");
        selectedLang = serializedObject.FindProperty("selectedLang");

        languages = serializedObject.FindProperty("languages");
    }

    public override void OnInspectorGUI() {
        serializedObject.Update();

        EditorGUILayout.PropertyField(library);
        EditorGUILayout.PropertyField(selectedLang);

        EditorGUI.BeginChangeCheck();
        EditorGUILayout.PropertyField(languages, true);
        if (EditorGUI.EndChangeCheck())
            serializedObject.ApplyModifiedProperties();
        EditorGUIUtility.LookLikeControls();


        serializedObject.ApplyModifiedProperties();
    }
    
}
