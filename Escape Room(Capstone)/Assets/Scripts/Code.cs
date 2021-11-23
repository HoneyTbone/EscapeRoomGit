using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Code : MonoBehaviour
{
    List<string> numbers = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

    PuzzleManager puzzleManager;
    int number1, number2, number3, number4;
    public Dropdown dropdown1, dropdown2, dropdown3, dropdown4;
    public bool completed;
    public GameObject codePuzzle;

    // Start is called before the first frame update
    void Awake()
    {
        puzzleManager = GameObject.FindGameObjectWithTag("PuzzleManager").GetComponent<PuzzleManager>();
    }

    public void Dropdown_IndexChanged(int index)
    {
        number1 = dropdown1.value;
        number2 = dropdown2.value;
        number3 = dropdown3.value;
        number4 = dropdown4.value;
        Debug.Log("1 " + dropdown1.value + " " + number1);
        Debug.Log("2 " + dropdown2.value + " " + number2);
        Debug.Log("3 " + dropdown3.value + " " + number3);
        Debug.Log("4 " + dropdown4.value + " " + number4);
    }

    void Start()
    {
        CreateList();
    }

    void Update()
    {
        if (number1 == 9 && number2 == 7 && number3 == 6 && number4 == 2)
        {
            puzzleManager.puzzles["code"] = true;
            completed = true;
        }
        if(completed == true)
        {
            isComplete();
        }
    }

    void CreateList()
    {
        dropdown1.AddOptions(numbers);
        dropdown2.AddOptions(numbers);
        dropdown3.AddOptions(numbers);
        dropdown4.AddOptions(numbers);
    }

    void isComplete()
    {
        puzzleManager.puzzles["code"] = true;
        puzzleManager.runTest = true;
        completed = false;
        codePuzzle.SetActive(false);
    }
}

