using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static HanoiTower;

public class HanoiTower : MonoBehaviour
{
    public enum HanoiLevel { Lv1 = 3, Lv2, Lv3 }
    public HanoiLevel hanoiLevel;

    public GameObject[] donutPrefabs;
    public BoardStick[] sticks; // L, C, R

    public TextMeshProUGUI countTextUI;
    public Button answerButton;

    public static GameObject selectedDonut;
    public static bool isSelected;
    public static BoardStick currStick;
    public static int moveCount;

    private void Awake()
    {
        answerButton.onClick.AddListener(HanoiAnswer);
    }

    IEnumerator Start()
    {
        // UI �ʱ�ȭ�� ������ �̵�
        moveCount = 0;
        countTextUI.text = moveCount.ToString();

        for (int i = (int)hanoiLevel - 1; i >= 0; i--) // �ݺ������� Level��ŭ ���ӻ���
        {
            GameObject donut = Instantiate(donutPrefabs[i]); // ���� ����
            donut.transform.position = new Vector3(-5f, 5f, 0f); // ���� ���� ��ġ: ���� ����� + ����

            sticks[0].PushDonut(donut); // ��� ������ ������ �ش� Stick�� Stack Push

            yield return new WaitForSeconds(1f); // ���������� ����
        }
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


    public void HanoiAnswer()
    {
        HanoiRoutine((int)hanoiLevel, 0, 1, 2);
    }

    private void HanoiRoutine(int n, int from, int temp, int to)
    {
        if (n == 1) // ������ �� �ű� ����
            Debug.Log($"{n}�� ������ {from}���� {to}�� �̵�");
        else
        {
            HanoiRoutine(n - 1, from, to, temp);
            Debug.Log($"{n}�� ������ {from}���� {to}�� �̵�");

            HanoiRoutine(n - 1, temp, from, to);
        }
    }
}