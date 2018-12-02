using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class GameStage : MonoBehaviour
{
    public GameObject _hpCircle;

    // 0hp - scale 0.0881;
    // 10hp - scale 1;
    private Music.BaseMusicSheet _sheet;

    public List<Transform> LeftGenPos;
    public List<Transform> RightGenPos;
    public List<Transform> DownGenPos;

    public List<Transform> LeftJudgePos;
    public List<Transform> RightJudgePos;
    public List<Transform> DownJudgePos;

    public GameObject RotateCircle;
    public AudioSource _audio;

    private int _score;

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

            if (_hp > 100.0f)
                _hp = 100.0f;
            else if (_hp <= 0)
                UnityEditor.EditorApplication.isPlaying = true;
        }
    }

    private void Start()
    {
        //_hp = 10.0f;
        Hp = 100.0f;
        _sheet = new Music1();
        _sheet.Init();
        StartCoroutine(StartStage());
        //InvokeRepeating("BeatAlert", 0, _sheet._beatSecond);

        Sequence seq = DOTween.Sequence();
        seq.Append(RotateCircle.transform.DORotate(new Vector3(0.0f, 0.0f, -720.0f), _sheet._beatSecond * 8.0f));
        seq.SetLoops(-1);
        seq.Play();
		InvokeRepeating("BeatAlert", 0, _sheet._beatSecond);

		Sequence seq = DOTween.Sequence();
		seq.Append(RotateCircle.transform.DORotate(new Vector3(0.0f, 0.0f, -720.0f), _sheet._beatSecond * 8.0f));
		seq.SetLoops(-1);
		//seq.Play();

        StartCoroutine(StageEnd());
    }

    private void Update()
    {
        var size = _hp * 1.118664f / 100;
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
        //Debug.Log("Perfect!");
        Hp += 8.0f;
        _score += 37;
    }

    public void OnNotBad(NoteObject note)
    {
        Debug.Log("NotBad!");
        Hp -= 2.0f;
        _score += 12;
        //Debug.Log("NotBad!");
        //Hp -= 2.0f;
		_score += 12;
    }

    public void OnMissed(NoteObject note)
    {
        //Debug.Log("Missed!");
        //Hp -= 7.0f;
    }

    private IEnumerator StageEnd()
    {
        yield return new WaitWhile(() => !_audio.isPlaying);
        yield return new WaitForSeconds(2.0f);
        PlayerPrefs.SetInt("Score", _score);
        SceneManager.LoadScene("Score");
    }
    IEnumerator StageEnd()
	{
		yield return new WaitForSeconds(_audio.clip.length);
		Debug.Log("스테이지 엔드 로그~");
		yield return new WaitForSeconds(1.0f);
		PlayerPrefs.SetInt("Score", _score);
		SceneManager.LoadScene("Score");
	}
}