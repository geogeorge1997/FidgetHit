using UnityEngine;

public class CameraScript : MonoBehaviour {

    public Camera m_OrthographicCamera;

    void Start()
    {
        transform.position = new Vector3(Screen.width / 2, Screen.height / 2, -10.0f);

        //This enables the Camera (the one that is orthographic)
        m_OrthographicCamera.enabled = true;

        //If the Camera exists in the inspector, enable orthographic mode and change the size
        if (m_OrthographicCamera)
        {
            //This enables the orthographic mode
            m_OrthographicCamera.orthographic = true;
            //Set the size of the viewing volume you'd like the orthographic Camera to pick up (5)
            m_OrthographicCamera.orthographicSize = Screen.height / 2;
        }
    }
}