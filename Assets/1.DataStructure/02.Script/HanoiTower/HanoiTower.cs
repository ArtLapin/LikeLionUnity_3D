using System.Collections;
using TMPro;
using UnityEngine;

public class HanoiTower : MonoBehaviour
{
    public enum HanoiLevel { Lv1 = 3, Lv2, Lv3 }
    public HanoiLevel hanoiLevel;
    
    public GameObject[] donutPrefabs;
    public BoardStick[] sticks; // L, C, R

    public TextMeshProUGUI countTextUI;

    public static GameObject selectedDonut;
    public static bool isSelected;
    public static BoardStick currStick;
    public static int moveCount;

    IEnumerator Start()
    {
        for (int i = (int)hanoiLevel - 1; i >= 0; i--) // �ݺ������� Level��ŭ ���ӻ���
        {
            GameObject donut = Instantiate(donutPrefabs[i]); // ���� ����
            donut.transform.position = new Vector3(-5f, 5f, 0f); // ���� ���� ��ġ: ���� ����� + ����

            sticks[0].PushDonut(donut); // ��� ������ ������ �ش� Stick�� Stack Push

            yield return new WaitForSeconds(1f); // ���������� ����
        }

        moveCount = 0;
        countTextUI.text = moveCount.ToString();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            currStick.stickStack.Push(selectedDonut);

            isSelected = false;
            selectedDonut = null;
        }
        countTextUI.text = moveCount.ToString();
    }
}