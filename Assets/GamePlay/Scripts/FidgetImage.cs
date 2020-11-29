using UnityEngine;

public class FidgetImage : MonoBehaviour
{
    public int set1;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;

    void Start()
    {
        set1 = PlayerPrefs.GetInt("Fidget", 1);
    }

    void Update()
    {
        if (set1 == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sprite1;
        }

        if (set1 == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sprite2;
        }

        if (set1 == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sprite3;
        }

        if (set1 == 4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sprite4;
        }

        if (set1 == 5)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sprite5;
        }
    }
}