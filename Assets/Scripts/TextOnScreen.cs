using UnityEngine;
using UnityEngine.UI;

public class TextOnScreen{


    public bool _textActive;
    public GameObject _textGameObject;
    public Text _text;
    public Vector3 _textMotion;
    public float _textDuration;
    public float _textLastShown;

    public void ShowText()
    {
        _textActive = true;
        _textLastShown = Time.time;
        _textGameObject.SetActive(true);
    }

    public void HideText()
    {
        _textActive = false;
        _textGameObject.SetActive(false);
    }


    public void UpdateFloatingText()
    {
        if (! _textActive)
            return;
        if (Time.time - _textLastShown > _textDuration)
            HideText();

        _textGameObject.transform.position += _textMotion * Time.deltaTime;
    }
}
