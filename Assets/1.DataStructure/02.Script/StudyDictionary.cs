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
        //persons.Add("Ã¶¼ö", 10);
        //persons.Add("¿µÈñ", 15);
        //persons.Add("µ¿¼ö", 17);

        //int age = persons["Ã¶¼ö"];
        //Debug.Log($"Ã¶¼öÀÇ ³ªÀÌ´Â {age}");

        //foreach (var person in persons)
        //{
        //    if (person.Value == 15)
        //    {
        //        Debug.Log($"³ªÀÌ°¡ 15ÀÎ »ç¶÷ÀÇ ÀÌ¸§Àº {person.Key}");
        //    }
        //    Debug.Log($"{person.Key}ÀÇ ³ªÀÌ´Â {person.Value}ÀÔ´Ï´Ù.");
        //}

        persons.Add("Ã¶¼ö", new PersonData(10, "Ã¶¼ö", 175f, 70f));
        persons.Add("¿µÈñ", new PersonData(10, "¿µÈñ", 175f, 70f));
        persons.Add("µ¿¼ö", new PersonData(10, "µ¿¼ö", 175f, 70f));

        Debug.Log(persons["Ã¶¼ö"].age);
        Debug.Log(persons["Ã¶¼ö"].name);
        Debug.Log(persons["Ã¶¼ö"].height);
        Debug.Log(persons["Ã¶¼ö"].weight);
    }
}
