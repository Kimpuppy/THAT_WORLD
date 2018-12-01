using UnityEngine;
using System.Collections;
using DG.Tweening;

public class NoteObject : MonoBehaviour
{
    public Music.Note _note;
    public float _genTime;
    public float _beatSecond;
    public AudioSource _audio;
    public static float _interpolateTime = 0.0f;
    private SpriteRenderer _spriteRenderer;
    private TrailRenderer _trailRenderer;
    private Color _noteColor;
    private bool _isStart = false;
    public bool _isHit;
    public GameStage _gameStage;

    public void Init()
    {
        _isHit = false;
        _gameStage = GameObject.Find("GameStage").GetComponent<GameStage>();
        _audio = GameObject.Find("BeatController").GetComponent<AudioSource>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _trailRenderer = GetComponent<TrailRenderer>();

        StartCoroutine(Setup());
    }

    private void Start()
    {
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        _spriteRenderer.color = new Color(0.0f, 0.0f, 0.0f, 0.0f) / 255.0f;
    }

    private void Update()
    {
        if (_isStart)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, Vector3.one, 2.5f * Time.deltaTime);
            _spriteRenderer.color = Color.Lerp(_spriteRenderer.color, _noteColor, 10.0f * Time.deltaTime);
        }
    }

    private IEnumerator Setup()
    {
        Sequence seq = DOTween.Sequence();
        seq.SetEase(Ease.InQuad);

        _noteColor = Color.white;
        _trailRenderer.startColor = _noteColor - new Color(0.0f, 0.0f, 0.0f, 0.25f);
        _trailRenderer.endColor = _noteColor - new Color(0.0f, 0.0f, 0.0f, 1.0f);

        switch (_note._genPos)
        {
            case Music.GenPos.Left:
                transform.position = _gameStage.LeftGenPos.transform.position;
                seq.Append(transform.DOLocalMove(_gameStage.LeftJudgePos.transform.position, 2 * _beatSecond + _interpolateTime));
                break;

            case Music.GenPos.Right:
                transform.position = _gameStage.RightGenPos.transform.position;
                seq.Append(transform.DOLocalMove(_gameStage.RightJudgePos.transform.position, 2 * _beatSecond + _interpolateTime));
                break;

            case Music.GenPos.Down:
                transform.position = _gameStage.DownGenPos.transform.position;
                seq.Append(transform.DOLocalMove(_gameStage.DownJudgePos.transform.position, 2 * _beatSecond + _interpolateTime));
                break;
        }

        seq.AppendCallback(() => { StartCoroutine(MissCheck()); });
        _genTime = _note._checkTime - _note._beat * _beatSecond;
        seq.Pause();

        yield return new WaitWhile(() => { return _audio.time < _genTime; });
        _isStart = true;
        seq.Play();
    }

    private IEnumerator MissCheck()
    {
        yield return new WaitForSeconds(0.3f);
        if (!_isHit)
        {
            _gameStage.OnMissed(this);
            Destroy(gameObject);
        }
    }
}