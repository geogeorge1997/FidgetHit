using UnityEngine;

public class NoThanks : MonoBehaviour {

    public void ClickNoThanks()
    {
        FindObjectOfType<ScoreCard>().OutCall();
    }

}