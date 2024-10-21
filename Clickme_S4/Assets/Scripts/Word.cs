using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;


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

    public async void playAudio(List <AudioClip> auds)
    {
        theSource.Stop();
        theSource.clip = auds[0];
        theSource.Play();
    
        await Task.Delay(3000);
        theSource.Stop();
        theSource.clip = auds[1];
        theSource.Play();
    
        await Task.Delay(3000);
        theSource.Stop();
        theSource.clip = auds[2];
        theSource.Play();
    }

}
