using UnityEngine;

public class Mode1 : MonoBehaviour
{
   public void M1()
    {
        PlayerPrefs.SetInt("Modes", 1);
        FindObjectOfType<BackGround>().news();
    }
}