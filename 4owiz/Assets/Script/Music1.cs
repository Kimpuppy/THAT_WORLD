using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music1 : Music.BaseMusicSheet
{
    public override void Setup()
    {
        System.Func<Music.Pattern> Blue = () =>
        {
            return new Music.Pattern(new List<Music.Note>{
                new Music.Note(2, Music.NoteType.One, Music.CheckType.Blue, Music.GenPos.Left)
            });
        };
        System.Func<Music.Pattern> Green = () =>
        {
            return new Music.Pattern(new List<Music.Note>{
                new Music.Note(2, Music.NoteType.One, Music.CheckType.Green, Music.GenPos.Down)
            });
        };
        System.Func<Music.Pattern> Red = () =>
        {
            return new Music.Pattern(new List<Music.Note>{
                new Music.Note(2, Music.NoteType.One, Music.CheckType.Red, Music.GenPos.Right)
            });
        };

        System.Func<Music.Pattern> BlueGreen = () =>
        {
            return new Music.Pattern(new List<Music.Note>{
                new Music.Note(2, Music.NoteType.One, Music.CheckType.Blue, Music.GenPos.Left),
                new Music.Note(2, Music.NoteType.One, Music.CheckType.Green, Music.GenPos.Left)
            });
        };

        System.Func<Music.Pattern> BlueRed = () =>
        {
            return new Music.Pattern(new List<Music.Note>{
                new Music.Note(2, Music.NoteType.One, Music.CheckType.Blue, Music.GenPos.Left),
                new Music.Note(2, Music.NoteType.One, Music.CheckType.Green, Music.GenPos.Left)
            });
        };

        System.Func<Music.Pattern> GreenRed = () =>
        {
            return new Music.Pattern(new List<Music.Note>{
                new Music.Note(2, Music.NoteType.One, Music.CheckType.Blue, Music.GenPos.Left),
                new Music.Note(2, Music.NoteType.One, Music.CheckType.Red, Music.GenPos.Left)
            });
        };

        System.Func<Music.Pattern> BlueGreenRed = () =>
        {
            return new Music.Pattern(new List<Music.Note>{
                new Music.Note(2, Music.NoteType.One, Music.CheckType.Blue, Music.GenPos.Left),
                new Music.Note(2, Music.NoteType.One, Music.CheckType.Green, Music.GenPos.Left),
                new Music.Note(2, Music.NoteType.One, Music.CheckType.Red, Music.GenPos.Left)
            });
        };

        _sheet1 = new List<Music.Action>();
        _sheet2 = new List<Music.Action>();
        _sheet3 = new List<Music.Action>();

        /// 노가다 해야함 ㅠㅠㅠ
        _sheet1.Add(new Music.Action(4, Blue()));
        _sheet1.Add(new Music.Action(6, Blue()));
        _sheet1.Add(new Music.Action(7, Blue()));

        _bpm = 160.0f;
    }
}