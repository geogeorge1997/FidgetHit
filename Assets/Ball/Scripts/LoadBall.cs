using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadBall : MonoBehaviour
{
   public void ClickBall()
    {
        SceneManager.LoadScene("Ball");
    }
}