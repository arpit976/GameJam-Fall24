using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Word : MonoBehaviour
{
    [SerializeField] public Text wordText;
    [SerializeField] public Image backGround;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeBGColor(Color color)
    {
        backGround.color = color;  
    }

    public void OnSelectWord()
    {
        VisualCueGameManager.instance.SetSelectedWord(this);
    }

}
