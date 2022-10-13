using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InfoForCube : MonoBehaviour
{
    [SerializeField] private TMP_InputField _speedInput, _timeInput, _distanceInput;
    [SerializeField] private Text _counting;
    CubeState cubeState;
    public static float _speed;
    private float _distance;
    public static float distance;
    private int _time;
    private int time;
    CubeMovement cubeMovement;
    private int i = 0;

    void Start()
    {
        _speedInput = GetComponent<TMP_InputField>();
        _timeInput = GetComponent<TMP_InputField>();
        _distanceInput = GetComponent<TMP_InputField>();
        cubeState = GetComponent<CubeState>();
        cubeMovement = GetComponent<CubeMovement>();
    }

    IEnumerator TimeCounting(int time)
    {
        while (i <= time)
        {
            yield return new WaitForSecondsRealtime(1.0f);
            _counting.text = $"{i}";
            i++;
            Debug.Log(i);
        }
        if (i >= time)
        {
            _counting.text = $"";
            cubeState.GoCube();
        }
    }

    public void InputSpeed(string s)
    {
        _speed = float.Parse(s);
        Debug.Log(_speed);
    }

    public void InputDistance(string g)
    {
        int _distance = int.Parse(g);
        Debug.Log(_distance);
        distance = _distance;
        StartCube(distance);
    }

    public void InputTime(string f)
    {
        int _time = int.Parse(f);
        Debug.Log(_time);
        time = _time;
    }

    public void StartCube(float distance)
    {
        StartCoroutine(TimeCounting(time));
        i = 0;
    }
}
