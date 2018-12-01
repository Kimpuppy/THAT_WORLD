using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music1 : Music.BaseMusicSheet
{
    public override void Setup()
    {
        System.Func<Music.Pattern> test1 = () =>
        {
            return new Music.Pattern(new List<Music.Note>{
                new Music.Note(2, Music.NoteType.One, Music.CheckType.Blue, Music.GenPos.Left)
            });
        };
        System.Func<Music.Pattern> test3 = () =>
        {
            return new Music.Pattern(new List<Music.Note>{
				new Music.Note(2, Music.NoteType.One, Music.CheckType.Green, Music.GenPos.Down)
            });
        };
        System.Func<Music.Pattern> test5 = () =>
        {
            return new Music.Pattern(new List<Music.Note>{
				new Music.Note(2, Music.NoteType.One, Music.CheckType.Red, Music.GenPos.Right)
            });
        };

        _sheet1 = new List<Music.Action>();
        _sheet2 = new List<Music.Action>();
        _sheet3 = new List<Music.Action>();

        /// 노가다 해야함 ㅠㅠㅠ
		_sheet1.Add(new Music.Action(4, test1()));
        _sheet1.Add(new Music.Action(8, test1()));
        _sheet1.Add(new Music.Action(12, test1()));
        _sheet1.Add(new Music.Action(16, test1()));
        _sheet1.Add(new Music.Action(20, test1()));
        _sheet1.Add(new Music.Action(24, test1()));
        _sheet1.Add(new Music.Action(28, test1()));
        _sheet1.Add(new Music.Action(32, test1()));
        _sheet1.Add(new Music.Action(36, test1()));
        _sheet1.Add(new Music.Action(40, test1()));
        _sheet2.Add(new Music.Action(16, test3()));
        _sheet2.Add(new Music.Action(20, test3()));
        _sheet2.Add(new Music.Action(24, test3()));
        _sheet2.Add(new Music.Action(28, test3()));
        _sheet2.Add(new Music.Action(32, test3()));
        _sheet2.Add(new Music.Action(36, test3()));
        _sheet3.Add(new Music.Action(24, test5()));
        _sheet3.Add(new Music.Action(28, test5()));
        _sheet3.Add(new Music.Action(32, test5()));
        _sheet3.Add(new Music.Action(36, test5()));

        _bpm = 160.0f;
    }
}