using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    public bool Sound;
    public int Value;
    public Sprite sprite1;
    public Sprite sprite2;
    public Button But;

    void Start()
    {
        Value = PlayerPrefs.GetInt("Sounds", 1);
        if (Value == 1)
        {
            But.image.sprite = sprite1;
        }
        else
        {
            But.image.sprite = sprite2;
        }
    }

    public void ClickSound()
    {
        Value = PlayerPrefs.GetInt("Sounds", 1);
        if (Value == 1)
        {
            But.image.sprite = sprite2;
            Sound = false;
            PlayerPrefs.SetInt("Sounds", 0);
            Debug.Log(Sound);
        }
        else
        {
            But.image.sprite = sprite1;
            Sound = true;
            PlayerPrefs.SetInt("Sounds", 1);
            Debug.Log(Sound);
        }
    }

}