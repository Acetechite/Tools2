using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TextAddOn))]
public class TextAddOnEditor : Editor {

    SerializedProperty englishText;
    SerializedProperty translatedText;

    void OnEnable()
    {
        englishText = serializedObject.FindProperty("englishText");
        translatedText = serializedObject.FindProperty("translatedText");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.PropertyField(englishText);
        EditorGUILayout.LabelField("Translated Text: ", translatedText.stringValue);

        serializedObject.ApplyModifiedProperties();
    }
}
