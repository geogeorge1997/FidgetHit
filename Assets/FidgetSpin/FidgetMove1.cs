using UnityEngine;

public class FidgetMove1 : MonoBehaviour
{
    float screenWidth = Screen.width;

    float angleT1;
    float Neg1;
   
    void Start()
    {
        transform.localScale = new Vector3(Screen.width / 7.39f, Screen.width / 7.39f, Screen.width / 100.0f);
        transform.position = new Vector3(Screen.width / 2, (Screen.height / 2), 0.0f);
    }

    void Update()
    {
         Touch touch = Input.GetTouch(0);
         if (touch.position.y >= (Screen.height / 2)-1)
         {
             angleT1 = (touch.deltaPosition.x * 180.0f) / screenWidth;
             Neg1 = -angleT1;
             transform.Rotate(0, 0, Neg1);
         }
         else
         {
             angleT1 = (touch.deltaPosition.x * 180.0f) / screenWidth;
             Neg1 = angleT1;
             transform.Rotate(0, 0, Neg1);
        }

         if (touch.position.x >= (Screen.width / 2) - 1)
         {
             angleT1 = (touch.deltaPosition.y * 180.0f) / Screen.height;
             Neg1 = angleT1;
             transform.Rotate(0, 0, Neg1);
         }
         else
         {
             angleT1 = (touch.deltaPosition.y * 180.0f) / Screen.height;
             Neg1 = -angleT1;
             transform.Rotate(0, 0, Neg1);
         }
    }
}