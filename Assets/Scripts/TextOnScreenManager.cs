using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextOnScreenManager : MonoBehaviour {

    public GameObject _textContainer;
    public GameObject _textPrefab;
    
    private List <TextOnScreen> _TextOnScreenArray = new List<TextOnScreen>();

    private TextOnScreen GetTextOnScreen()
    {
        TextOnScreen txt = _TextOnScreenArray.Find(t => !t._textActive);

        if (txt == null)
        {
            txt = new TextOnScreen();
            txt._textGameObject = Instantiate(_textPrefab);
            txt._textGameObject.transform.SetParent(_textContainer.transform);
            txt._text = txt._textGameObject.GetComponent<Text>();

            _TextOnScreenArray.Add(txt);
        }
        return txt;
    }

    public void Show(string message, int fontsize, Color color, Vector3 position, Vector3 motion, float duration)
    {
        TextOnScreen floatingText = GetTextOnScreen();

        floatingText._text.text = message;
        floatingText._text.fontSize = fontsize;
        floatingText._text.color = color;
        //transfer would space to screen space so that we can use it on the UI
        floatingText._textGameObject.transform.position = Camera.main.WorldToScreenPoint(position);
        floatingText._textMotion = motion;
        floatingText._textDuration = duration;

        floatingText.ShowText();
    }
    private void Update()
    {
        foreach (TextOnScreen txt in _TextOnScreenArray)
            txt.UpdateFloatingText();
    }
}
