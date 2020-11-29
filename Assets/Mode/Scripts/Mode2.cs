using UnityEngine;

public class Mode2 : MonoBehaviour
{
    public void M2()
    { 
            PlayerPrefs.SetInt("Modes", 2);
            FindObjectOfType<BackGround>().news();
    }
}