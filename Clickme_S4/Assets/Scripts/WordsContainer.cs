using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordsContainer : MonoBehaviour
{
    [SerializeField] private bool IsAcceptingWord= false;
    [SerializeField] private List<Word> words;
    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnContainerClick()
    {
        if (index > words.Count)
            return;
        words[index].SetWordData(VisualCueGameManager.instance.SelectedWord.wordData);
        VisualCueGameManager.instance.RemoveSelectedWord();
        if(words[index].wordData.iSWord == IsAcceptingWord)
        {
            words[index].ChangeBGColor(Color.green);
        }
        else
        {
            words[index].ChangeBGColor(Color.red);
        }

        index++;
    }

}
