using UnityEngine;

public class BallImage : MonoBehaviour
{
    public int set2;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite sprite6;
    public Sprite sprite7;

    void Start()
    {
        set2 = PlayerPrefs.GetInt("Ball", 1);
    }
    void Update()
    {
        if (set2 == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sprite1;
        }

        if (set2 == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sprite2;
        }

        if (set2 == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sprite3;
        }

        if (set2 == 4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sprite4;
        }

        if (set2 == 5)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sprite5;
        }

        if (set2 == 6)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sprite6;
        }

        if (set2 == 7)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sprite7;
        }
    }
}