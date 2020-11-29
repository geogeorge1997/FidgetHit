using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadFidget : MonoBehaviour
{
    public void ClickFidget()
    {
        SceneManager.LoadScene("Fidget");
    }
}