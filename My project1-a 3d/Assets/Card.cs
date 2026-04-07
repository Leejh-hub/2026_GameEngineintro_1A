using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Card : MonoBehaviour
{

    public float rotateY;
    public TextMeshProUGUI text;
    public bool isFront = true;
    private Quaternion flipRotation = Quaternion.Euler(0, 180f, 0);
    private Quaternion originRotation = Quaternion.Euler(0, 0, 0);
    public int number;
    public CardGame cardGame;
    public bool isMatched = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // && and || or
        // 0 => 180 => -180 => 0

        //0 < y < 180
        
        float currentY = transform.eulerAngles.y;

        if(isFront)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, originRotation, rotateY * Time.deltaTime);
        }
        else
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, flipRotation, rotateY * Time.deltaTime);
        }
        //if(isClick)
        //{
            //transform.rotation = Quaternion.Slerp(transform.rotation, flipRotation, rotateY * Time.deltaTime);
            //if (currentY >= 0 && currentY < 180)
            //{
            //    transform.Rotate(0, rotateY, 0);
            //}
        //}
        //else
        //{
        //    transform.rotation = Quaternion.Slerp(transform.rotation, originRotation, rotateY * Time.deltaTime);
        //}

        
        
    }
    public void ClickCard()
    {
        if (isMatched)
        {

        }
        else
        {
            cardGame.OnClickCard(this);
            isFront = !isFront;
        }
        
    }
    ///public void ClickCard()
    //{
    //    isClick = !isClick;
    //}

    //밖에서 카드 넘버 할당
    public void SetCardnumber(int newNumber)
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
        number = newNumber;
        text.text = number.ToString();
        //text.text = Random.Range(0, 10).ToString();
    }
    public void ChangeColor(Color newColor)
    {
        GetComponent<Image>().color = newColor;
    }
}
