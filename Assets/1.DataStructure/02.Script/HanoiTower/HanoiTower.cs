using System.Collections;
using UnityEngine;

public class HanoiTower : MonoBehaviour
{
    public enum HanoiLevel { Lv1 = 3, Lv2, Lv3 }
    public HanoiLevel hanoiLevel;
    
    public GameObject[] donutPrefabs;
    public BoardStick[] sticks; // L, C, R

    public static GameObject selectedDonut;
    public static bool isSelected;

    IEnumerator Start()
    {
        for (int i = (int)hanoiLevel - 1; i >= 0; i--) // �ݺ������� Level��ŭ ���ӻ���
        {
            GameObject donut = Instantiate(donutPrefabs[i]); // ���� ����
            donut.transform.position = new Vector3(-5f, 5f, 0f); // ���� ���� ��ġ: ���� ����� + ����

            sticks[0].PushDonut(donut); // ��� ������ ������ �ش� Stick�� Stack Push

            yield return new WaitForSeconds(1f); // ���������� ����
        }
    }
}