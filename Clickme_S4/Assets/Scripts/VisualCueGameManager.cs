using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VisualCueGameManager : MonoBehaviour
{
    public static VisualCueGameManager instance;
    public Color color;

    private Word selectedWord;

    // Start is called before the first frame update
    void Start()
    {
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
        selectedWord.playAudio(word.sounds);

    }
}
