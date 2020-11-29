using UnityEngine;
using UnityEngine.UI;

public class BallMove : MonoBehaviour
{

    public Rigidbody2D m_Rigidbody2D;
    public float BallSpeed;
    public float pixel;
    public int SpeedRate,BallPosNum;
    public float SpeedInc;
    public Text Level;

    void Start()
    {
        SpeedInc = 882.0f;
        pixel = Screen.height * Screen.width;
        BallSpeed = pixel / SpeedInc;
        m_Rigidbody2D = GetComponent<Rigidbody2D>();

        transform.localScale = new Vector3(Screen.width / 30.0f, Screen.width / 30.0f, Screen.width / 30.0f);
        transform.position = new Vector3(Screen.width / 2, (Screen.height / 1.4f), 0.0f);
    }

    void Update()
    {
        SpeedRate = PlayerPrefs.GetInt("scoreInc", 0);

        if (SpeedRate >= 0 && SpeedRate <= 9)
        {
            SpeedInc = 882.0f;
        }
        else if (SpeedRate == 10)
        {
            SpeedInc = 766.0f;
        }

        else if (SpeedRate == 24)
        {
            SpeedInc = 640.0f;
        }

        else if (SpeedRate == 40)
        {
            SpeedInc = 550.0f;
        }

        else if (SpeedRate == 56)
        {
            SpeedInc = 460.0f;
        }

        else if (SpeedRate == 73)
        {
            SpeedInc = 370.0f;
        }

        else if (SpeedRate == 91)
        {
            SpeedInc = 334.0f;
        }

        BallSpeed = pixel / SpeedInc;

        if (m_Rigidbody2D.position.x > Screen.width || m_Rigidbody2D.position.x < 0)
        {
            transform.position = new Vector3(Screen.width / 2, (Screen.height / 1.4f), 0.0f);

        }

        if (m_Rigidbody2D.position.y > Screen.height || m_Rigidbody2D.position.y < Screen.height/4.0f)
        {
            transform.position = new Vector3(Screen.width / 2, (Screen.height / 1.4f), 0.0f);
        }

        if (m_Rigidbody2D.velocity.y >= BallSpeed)
        {
            Debug.Log(m_Rigidbody2D.velocity.y);
            m_Rigidbody2D.velocity = Vector2.down / 2;
            Debug.Log(m_Rigidbody2D.velocity.y);
            m_Rigidbody2D.AddForce(transform.right * 8200.0f);
        }

        if (m_Rigidbody2D.velocity.x >= BallSpeed)
        {
            Debug.Log(m_Rigidbody2D.velocity.x);
            m_Rigidbody2D.velocity = Vector2.left / 2;
            Debug.Log(m_Rigidbody2D.velocity.x);
            m_Rigidbody2D.AddForce(transform.up * 7300.0f);
        }

        if (m_Rigidbody2D.velocity.y <= -BallSpeed)
        {
            Debug.Log(m_Rigidbody2D.velocity.y);
            m_Rigidbody2D.velocity = Vector2.down / 2;
            Debug.Log(m_Rigidbody2D.velocity.y);
            m_Rigidbody2D.AddForce(-transform.right * 10000.0f);
        }

        if (m_Rigidbody2D.velocity.x <= -BallSpeed)
        {
            Debug.Log(m_Rigidbody2D.velocity.x);
            m_Rigidbody2D.velocity = Vector2.left / 2;
            Debug.Log(m_Rigidbody2D.velocity.x);
            m_Rigidbody2D.AddForce(-transform.up * 6400.0f);
        }
    }

    public void BallPos()
    {
        BallPosNum = Random.Range(1, 3);
        if (BallPosNum == 1)
        {
            m_Rigidbody2D.AddForce(transform.right * 3700.0f);
        }
        else
        {
            m_Rigidbody2D.AddForce(-transform.right * 3700.0f);
        }
    }

}