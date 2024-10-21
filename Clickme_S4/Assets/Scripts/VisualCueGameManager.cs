using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VisualCueGameManager : MonoBehaviour
{
    public static VisualCueGameManager instance;
    public Color color;

    [SerializeField] private List<LetterSO> letters;
    private LetterSO selectedLetterSO;
    [SerializeField] private List<Word> words;
    private Word selectedWord;

    // Start is called before the first frame update
    void Start()
    {
        selectedLetterSO = letters[0];
        if (instance == null)
            instance = this;
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSelectedWord(Word word)
    {
        selectedWord?.ChangeBGColor(color);
        selectedWord = word;
        selectedWord.ChangeBGColor(Color.green);
    }
}
