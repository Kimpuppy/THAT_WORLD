﻿using UnityEngine;
using System.Collections;
using DG.Tweening;

public class GameStage : MonoBehaviour
{
    public GameObject _hpCircle;

    // 0hp - scale 0.0881;
    // 10hp - scale 1;
    private Music.BaseMusicSheet _sheet;
	public GameObject LeftGenPos;
	public GameObject RightGenPos;
	public GameObject DownGenPos;
    public GameObject LeftJudgePos;
	public GameObject RightJudgePos;
	public GameObject DownJudgePos;

    private int _beat;

    private float _hp;

    public float Hp
    {
        get
        {
            return _hp;
        }
        set
        {
            _hp = value;

            if (_hp > 10.0f)
                _hp = 10.0f;
            else if (_hp <= 0)
                UnityEditor.EditorApplication.isPlaying = false;
        }
    }

    private void Start()
    {
        //_hp = 10.0f;
        Hp = 10.0f;
        _sheet = new Music1();
        _sheet.Init();
        StartCoroutine(StartStage());
		//InvokeRepeating("BeatAlert", 0, _sheet._beatSecond);

		Sequence seq = DOTween.Sequence();
		seq.Append(_hpCircle.transform.DORotate(new Vector3(0.0f, 0.0f, -720.0f), _sheet._beatSecond * 8.0f));
		seq.SetLoops(-1);
		seq.Play();
    }

    private void Update()
    {
        var size = 0.881f + (1 - 0.881f) / 10 * _hp;
        _hpCircle.transform.localScale = Vector2.Lerp(_hpCircle.transform.localScale, new Vector3(size, size), 5.0f * Time.deltaTime);
    }

    private void BeatAlert()
    {
        Debug.LogFormat("Beat - {0}", _beat++);
    }

    private IEnumerator StartStage()
    {
        for (int i = 0; i < _sheet._sheet1.Count; i++)
        {
            for (int j = 0; j < _sheet._sheet1[i]._pattern._notes.Count; j++)
            {
                var noteObj = Instantiate(Resources.Load<GameObject>("Prefab/LeftNote"));
                var script = noteObj.GetComponent<NoteObject>();
                script._beatSecond = _sheet._beatSecond;
                script._note = _sheet._sheet1[i]._pattern._notes[j];
                script.Init();
            }
        }

        for (int i = 0; i < _sheet._sheet2.Count; i++)
        {
            for (int j = 0; j < _sheet._sheet2[i]._pattern._notes.Count; j++)
            {
                var noteObj = Instantiate(Resources.Load<GameObject>("Prefab/DownNote"));
                var script = noteObj.GetComponent<NoteObject>();
                script._beatSecond = _sheet._beatSecond;
                script._note = _sheet._sheet2[i]._pattern._notes[j];
                script.Init();
            }
        }

        for (int i = 0; i < _sheet._sheet3.Count; i++)
        {
            for (int j = 0; j < _sheet._sheet3[i]._pattern._notes.Count; j++)
            {
                var noteObj = Instantiate(Resources.Load<GameObject>("Prefab/RightNote"));
                var script = noteObj.GetComponent<NoteObject>();
                script._beatSecond = _sheet._beatSecond;
                script._note = _sheet._sheet3[i]._pattern._notes[j];
                script.Init();
            }
        }
        yield break;
    }

    public void OnPerfect(NoteObject note)
    {
        Debug.Log("Perfect!");
        Hp += 3.0f;
    }

    public void OnNotBad(NoteObject note)
    {
        Debug.Log("NotBad!");
        Hp -= 1.0f;
    }

    public void OnMissed(NoteObject note)
    {
        Debug.Log("Missed!");
        Hp -= 2.0f;
    }
}