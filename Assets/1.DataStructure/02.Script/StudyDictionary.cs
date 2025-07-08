using System.Collections.Generic;
using UnityEngine;

public class PersonData
{
    public int age;
    public string name;
    public float height;
    public float weight;

    public PersonData(int age, string name, float height, float weight)
    {
        this.age = age;
        this.name = name;
        this.height = height;
        this.weight = weight;
    }
}

public class StudyDictionary : MonoBehaviour
{
    public Dictionary<string, PersonData> persons = new Dictionary<string, PersonData>();

    private void Start()
    {
        //persons.Add("ö��", 10);
        //persons.Add("����", 15);
        //persons.Add("����", 17);

        //int age = persons["ö��"];
        //Debug.Log($"ö���� ���̴� {age}");

        //foreach (var person in persons)
        //{
        //    if (person.Value == 15)
        //    {
        //        Debug.Log($"���̰� 15�� ����� �̸��� {person.Key}");
        //    }
        //    Debug.Log($"{person.Key}�� ���̴� {person.Value}�Դϴ�.");
        //}

        persons.Add("ö��", new PersonData(10, "ö��", 175f, 70f));
        persons.Add("����", new PersonData(10, "����", 175f, 70f));
        persons.Add("����", new PersonData(10, "����", 175f, 70f));

        Debug.Log(persons["ö��"].age);
        Debug.Log(persons["ö��"].name);
        Debug.Log(persons["ö��"].height);
        Debug.Log(persons["ö��"].weight);
    }
}
