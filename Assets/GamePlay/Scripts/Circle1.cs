using UnityEngine;

public class Circle1 : MonoBehaviour {

    public GameObject CirlceOne;

	void Start ()
    {
        Invoke("CallCut", 2.5f);
	}
	
	void CallCut ()
    {
        CirlceOne.gameObject.SetActive(false);
	}
}