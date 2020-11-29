using UnityEngine;
using UnityEngine.UI;

public class VibrationButton : MonoBehaviour
{
    public bool Vibrat;
    public int Value1;
    public Sprite sprite1;
    public Sprite sprite2;
    public Button But;

    void Start()
    {
        Value1 = PlayerPrefs.GetInt("Vibration", 1);
        if (Value1 == 1)
        {
            But.image.sprite = sprite1;
        }
        else
        {
            But.image.sprite = sprite2;
        }
    }

    public void ClickVibration()
    {
        Value1 = PlayerPrefs.GetInt("Vibration", 1);
        if (Value1 == 1)
        {
            But.image.sprite = sprite2;
            Vibrat = false;
            PlayerPrefs.SetInt("Vibration", 0);
            Debug.Log(Vibrat);
        }
        else
        {
            But.image.sprite = sprite1;
            Vibrat = true;
            PlayerPrefs.SetInt("Vibration", 1);
            Debug.Log(Vibrat);
        }
    }

}