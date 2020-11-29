using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpButton : MonoBehaviour {

	public void HelpPress()
    {
        SceneManager.LoadScene("Helps");
    }
}