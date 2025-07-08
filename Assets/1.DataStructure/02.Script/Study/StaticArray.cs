using UnityEngine;
using UnityEngine.Rendering;

public class ArrayStudy : MonoBehaviour
{
    // 자료형 [] : 정적 배열
    int[] array1; // 정적 배열 선언
    int[] array2 = {10,20,30, 40, 50}; // 정적 배열 선언과 초기화
    int[] array3 = new int[5]; // 정적 배열 선언과 공간 할당
    int[] array4 = new int[5] { 10, 20, 30, 40, 50 }; // 정적 배열 선언 및 공간할당 + 초기화

    void Start()
    {
        int number = array2[3]; // 정적 배열의 값을 가져옴
    }
}
