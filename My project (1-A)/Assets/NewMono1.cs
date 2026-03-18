using UnityEngine;

public class NewMonoBehaviourScript1 : MonoBehaviour
{



    //object oriented
        // 객체 지향 언어 / C# -> 객체 지향 언어
        // 절차 지향 / 지금 X

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 변수 = 그릇

        // int a;
        // float b;
        // string c;
        // bool d;

       

        Human man = new Human();
        man.age = 20;
        man.kg = 61.2f;
        man.height = 173.2f;
        man.name = "신구";

        man.Introduce();

        Human man2 = new Human();
        man2.name = "구신";

        man.Attack(man2);

        Debug.Log(man2.Hp);
    }

    // Update is called once per frame
    void Update()
    {   
    }
    
    int Plus(int left, int right)
    {
        int value = left + right;
        return value;
    }
    int Minus(int left, int right)
    {
        int value = left - right;
        return value;
    }
    int Multiply(int left, int right)
    {
        int value = left * right;
        return value;
    }
    int Divide(int left, int right)
    {
        int value = left / right;
        return value;
    }
    int PlusMInus(int left, int right, bool isPlus)
    {
        if(isPlus == true)
        {
            return left + right;
        }
        else
        {
            return left - right;
        }
    }
    






}
