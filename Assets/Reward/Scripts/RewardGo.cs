using UnityEngine;
using UnityEngine.SceneManagement;

public class RewardGo : MonoBehaviour {//Loading CreditScene

	public void Goto()
    {
        SceneManager.LoadScene("Credit");
    }
}