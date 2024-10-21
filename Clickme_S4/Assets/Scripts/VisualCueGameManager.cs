using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VisualCueGameManager : MonoBehaviour
{
    public static VisualCueGameManager instance;
    public Color color;
    public Word SelectedWord { get; private set; }

    [SerializeField] private List<LetterSO> letters;
    private LetterSO selectedLetterSO;
    [SerializeField] private List<Word> words;

    // Start is called before the first frame update
    void Start()
    {
        selectedLetterSO = letters[0];
        if (instance == null)
            instance = this;
        SetWord();

    }

    public void RemoveSelectedWord()
    {
        SelectedWord.gameObject.SetActive(false);
        SelectedWord = null;
    }

    private void SetWord()
    {
        for (int i = 0; i < selectedLetterSO.words.Count; i++)
        {
            words[i].SetWordData(selectedLetterSO.words[i]);
            words[i].OnClick(SetSelectedWord);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetSelectedWord(Word word)
    {
        SelectedWord?.ChangeBGColor(color);
        SelectedWord = word;
        SelectedWord.ChangeBGColor(Color.green);
    }
}
