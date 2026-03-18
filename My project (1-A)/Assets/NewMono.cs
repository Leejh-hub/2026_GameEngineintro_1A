using UnityEngine;

public class Human
{
    public object brain;
    public object blood;

    public float kg;
    public float height;
    public int age;
    public string name;

    public float Hp = 100f;

    public void Walk()
    {
        Debug.Log("걷다");
        //
    }
    public void Eat()
    {
        Debug.Log("먹다");
        //
    }
    public void Sleep()
    {
        Debug.Log("ZZzzz");
        //
    }
    public void Introduce()
    {
        Debug.Log("안녕하세요" + "나이 :" + age + "키 :" + height + "제 이름은 :" + name + "입니다");
    }
    public void Attack(Human human)
    {
        human.Hp -= 5f;
    }
}
