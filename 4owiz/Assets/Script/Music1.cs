using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music1 : Music.BaseMusicSheet
{
    public override void Setup()
    {
        System.Func<Music.Pattern> LBlue = () =>
        {
            return new Music.Pattern(new List<Music.Note>{
                new Music.Note(2, Music.NoteType.One, Music.CheckType.Blue, Music.GenPos.Left)
            });
        };
        System.Func<Music.Pattern> LGreen = () =>
        {
            return new Music.Pattern(new List<Music.Note>{
                new Music.Note(2, Music.NoteType.One, Music.CheckType.Green, Music.GenPos.Left)
            });
        };
        System.Func<Music.Pattern> LRed = () =>
        {
            return new Music.Pattern(new List<Music.Note>{
                new Music.Note(2, Music.NoteType.One, Music.CheckType.Red, Music.GenPos.Left)
            });
        };

        System.Func<Music.Pattern> RBlue = () =>
        {
            return new Music.Pattern(new List<Music.Note>{
                new Music.Note(2, Music.NoteType.One, Music.CheckType.Blue, Music.GenPos.Right)
            });
        };
        System.Func<Music.Pattern> RGreen = () =>
        {
            return new Music.Pattern(new List<Music.Note>{
                new Music.Note(2, Music.NoteType.One, Music.CheckType.Green, Music.GenPos.Right)
            });
        };
        System.Func<Music.Pattern> RRed = () =>
        {
            return new Music.Pattern(new List<Music.Note>{
                new Music.Note(2, Music.NoteType.One, Music.CheckType.Red, Music.GenPos.Right)
            });
        };

        System.Func<Music.Pattern> DBlue = () =>
        {
            return new Music.Pattern(new List<Music.Note>{
                new Music.Note(2, Music.NoteType.One, Music.CheckType.Blue, Music.GenPos.Down)
            });
        };
        System.Func<Music.Pattern> DGreen = () =>
        {
            return new Music.Pattern(new List<Music.Note>{
                new Music.Note(2, Music.NoteType.One, Music.CheckType.Green, Music.GenPos.Down)
            });
        };
        System.Func<Music.Pattern> DRed = () =>
        {
            return new Music.Pattern(new List<Music.Note>{
                new Music.Note(2, Music.NoteType.One, Music.CheckType.Red, Music.GenPos.Down)
            });
        };

        _sheet1 = new List<Music.Action>();
        _sheet2 = new List<Music.Action>();
        _sheet3 = new List<Music.Action>();

        /// 노가다 해야함 ㅠㅠㅠ

        _sheet1.Add(new Music.Action(4, LBlue()));
        _sheet1.Add(new Music.Action(8, LBlue()));
        _sheet1.Add(new Music.Action(12, LGreen()));
        _sheet1.Add(new Music.Action(16, LRed()));
        _sheet1.Add(new Music.Action(20, LBlue()));
        _sheet1.Add(new Music.Action(24, LBlue()));
        _sheet1.Add(new Music.Action(28, LGreen()));
        _sheet1.Add(new Music.Action(32, LRed()));

        _sheet1.Add(new Music.Action(36, RBlue()));
        _sheet1.Add(new Music.Action(40, RGreen()));
        _sheet1.Add(new Music.Action(44, RRed()));
        _sheet1.Add(new Music.Action(48, RBlue()));
        _sheet1.Add(new Music.Action(52, RGreen()));
        _sheet1.Add(new Music.Action(56, RRed()));
        _sheet1.Add(new Music.Action(60, RBlue()));
        _sheet1.Add(new Music.Action(64, RRed()));

        _sheet1.Add(new Music.Action(68, RBlue()));
        _sheet1.Add(new Music.Action(72, RGreen()));
        _sheet1.Add(new Music.Action(76, RRed()));
        _sheet1.Add(new Music.Action(80, RBlue()));
        _sheet1.Add(new Music.Action(84, RGreen()));
        _sheet1.Add(new Music.Action(88, RRed()));
        _sheet1.Add(new Music.Action(92, RBlue()));
        _sheet1.Add(new Music.Action(96, RRed()));

        _sheet2.Add(new Music.Action(36, RBlue()));
        _sheet2.Add(new Music.Action(40, RGreen()));
        _sheet2.Add(new Music.Action(44, RRed()));
        _sheet2.Add(new Music.Action(48, RBlue()));
        _sheet2.Add(new Music.Action(52, RGreen()));
        _sheet2.Add(new Music.Action(56, RRed()));
        _sheet2.Add(new Music.Action(60, RBlue()));
        _sheet2.Add(new Music.Action(64, RRed()));

        _sheet2.Add(new Music.Action(68, RBlue()));
        _sheet2.Add(new Music.Action(72, RGreen()));
        _sheet2.Add(new Music.Action(76, RRed()));
        _sheet2.Add(new Music.Action(80, RBlue()));
        _sheet2.Add(new Music.Action(84, RGreen()));
        _sheet2.Add(new Music.Action(88, RRed()));
        _sheet2.Add(new Music.Action(92, RBlue()));
        _sheet2.Add(new Music.Action(96, RRed()));

        _bpm = 160.0f;
    }
}