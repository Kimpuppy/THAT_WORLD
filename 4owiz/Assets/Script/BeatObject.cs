using UnityEngine;

public class BeatObject : MonoBehaviour
{
    public float OnSize;
    public float OffSize;

    private BeatController _beatController;

    private int _beatCount = 0;

    private void Start()
    {
        _beatController = GameObject.Find("BeatController").GetComponent<BeatController>();
    }

    private void Update()
    {
        if (_beatController.IsBeat)
        {
            _beatCount++;
            transform.localScale = new Vector3(OnSize, OnSize, OnSize);
        }
        transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(OffSize, OffSize, OffSize), 5.0f * Time.deltaTime);
        transform.localEulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0.0f, 0.0f, (_beatCount % 4.0f) * 120.0f), 5.0f * Time.deltaTime);
    }
}