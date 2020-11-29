using UnityEngine;
using UnityEngine.SceneManagement;

public class ThemeButton : MonoBehaviour {

    public void ClickTheme()
    {
        SceneManager.LoadScene("Fidget");
    }
}