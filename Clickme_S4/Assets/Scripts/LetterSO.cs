using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "LetterData", menuName = "ScriptableObject/LetterSO")]
public class LetterSO : ScriptableObject
{
    public string mainletter;
    public Color color;
    public List<string> letterNames;
    public List<WordData> words;
}
