using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Music;

public class Music1 : BaseMusicSheet
{
    public override void Setup()
    {
        System.Func<Music.Pattern> LBlue = () =>
        System.Func<Pattern> FirstMelody = () =>
        {
            return new Pattern(new List<Note> {
                new Note(0, NoteType.One, CheckType.Blue, GenPos.Left),
                new Note(4, NoteType.One, CheckType.Green, GenPos.Left),
                new Note(8, NoteType.One, CheckType.Red, GenPos.Left),
                new Note(12, NoteType.One, CheckType.Green, GenPos.Left)
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
        
        System.Func<Pattern> BaseLoop = () =>
        {
            return new Pattern(new List<Note> {
                new Note(0, NoteType.One, CheckType.Green, GenPos.Right),
                new Note(1.5f, NoteType.One, CheckType.Green, GenPos.Right),
                new Note(3, NoteType.One, CheckType.Green, GenPos.Right),
                new Note(4.5f, NoteType.One, CheckType.Green, GenPos.Right),
                new Note(6, NoteType.One, CheckType.Green, GenPos.Right),
                new Note(7, NoteType.One, CheckType.Red, GenPos.Right),

                new Note(8+0, NoteType.One, CheckType.Blue, GenPos.Right),
                new Note(8+1.5f, NoteType.One, CheckType.Blue, GenPos.Right),
                new Note(8+3, NoteType.One, CheckType.Blue, GenPos.Right),
                new Note(8+4.5f, NoteType.One, CheckType.Blue, GenPos.Right),
                new Note(8+6, NoteType.One, CheckType.Blue, GenPos.Right),
                new Note(8+7, NoteType.One, CheckType.Red, GenPos.Right),

                new Note(16+0, NoteType.One, CheckType.Green, GenPos.Right),
                new Note(16+1.5f, NoteType.One, CheckType.Green, GenPos.Right),
                new Note(16+3, NoteType.One, CheckType.Green, GenPos.Right),
                new Note(16+4.5f, NoteType.One, CheckType.Green, GenPos.Right),
                new Note(16+6, NoteType.One, CheckType.Green, GenPos.Right),
                new Note(16+7, NoteType.One, CheckType.Red, GenPos.Right),

                new Note(16+0, NoteType.One, CheckType.Blue, GenPos.Right),
                new Note(16+1.5f, NoteType.One, CheckType.Blue, GenPos.Right),
                new Note(16+3, NoteType.One, CheckType.Blue, GenPos.Right),
                new Note(16+4.5f, NoteType.One, CheckType.Blue, GenPos.Right),
                new Note(16+6, NoteType.One, CheckType.Blue, GenPos.Right),

                new Note(24+0, NoteType.One, CheckType.Green, GenPos.Right),
                new Note(24+1.5f, NoteType.One, CheckType.Green, GenPos.Right),
                new Note(24+3, NoteType.One, CheckType.Green, GenPos.Right),
                new Note(24+4.5f, NoteType.One, CheckType.Green, GenPos.Right),
                new Note(24+6, NoteType.One, CheckType.Blue, GenPos.Right),
                new Note(24+6.5f, NoteType.One, CheckType.Red, GenPos.Right),
                new Note(24+7, NoteType.One, CheckType.Green, GenPos.Right),
            });
        };

        System.Func<Pattern> SubMelody = () =>
        {
            return new Pattern(new List<Note> {
                new Note(0, NoteType.One, CheckType.Green, GenPos.Down),
				new Note(2, NoteType.One, CheckType.Blue, GenPos.Down),
				new Note(4, NoteType.One, CheckType.Green, GenPos.Down),
				new Note(6, NoteType.One, CheckType.Red, GenPos.Down),
            });
		};
        
		System.Func<Pattern> SubInterludeMelody = () =>
        {
            return new Pattern(new List<Note> {
                new Note(0, NoteType.One, CheckType.Blue, GenPos.Down),
                new Note(4, NoteType.One, CheckType.Green, GenPos.Down),
                new Note(8, NoteType.One, CheckType.Red, GenPos.Down),
				new Note(12, NoteType.One, CheckType.Blue, GenPos.Down),
				new Note(16, NoteType.One, CheckType.Red, GenPos.Down),
				new Note(20, NoteType.One, CheckType.Green, GenPos.Down),
                new Note(24, NoteType.One, CheckType.Green, GenPos.Down),
				new Note(24, NoteType.One, CheckType.Blue, GenPos.Down),
				new Note(28, NoteType.One, CheckType.Blue, GenPos.Down),
				new Note(30, NoteType.One, CheckType.Red, GenPos.Down),
				new Note(32, NoteType.One, CheckType.Green, GenPos.Down),
                new Note(36, NoteType.One, CheckType.Blue, GenPos.Down),
				new Note(32+6, NoteType.One, CheckType.Red, GenPos.Down),
				new Note(32+7, NoteType.One, CheckType.Green, GenPos.Down),
				new Note(32+8, NoteType.One, CheckType.Blue, GenPos.Down),
				new Note(32+12, NoteType.One, CheckType.Green, GenPos.Down),
                new Note(32+15, NoteType.One, CheckType.Green, GenPos.Down),
				new Note(32+16, NoteType.One, CheckType.Red, GenPos.Down),  
                new Note(32+20, NoteType.One, CheckType.Green, GenPos.Down),
                new Note(32+24, NoteType.One, CheckType.Red, GenPos.Down),
                new Note(32+24, NoteType.One, CheckType.Blue, GenPos.Down),
                new Note(32+28, NoteType.One, CheckType.Green, GenPos.Down),
				new Note(32+30, NoteType.One, CheckType.Red, GenPos.Down),
				new Note(32+32, NoteType.One, CheckType.Green, GenPos.Down),
            });
        };
        ///

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
        System.Func<Pattern> Finale1 = () =>
        {
            return new Pattern(new List<Note> {
                new Note(0, NoteType.One, CheckType.Blue, GenPos.Left),
                new Note(0, NoteType.One, CheckType.Green, GenPos.Left),
                new Note(0, NoteType.One, CheckType.Red, GenPos.Left)
            });
        };
        System.Func<Pattern> Finale2 = () =>
        {
            return new Pattern(new List<Note> {
                new Note(0, NoteType.One, CheckType.Blue, GenPos.Down),
                new Note(0, NoteType.One, CheckType.Green, GenPos.Down),
                new Note(0, NoteType.One, CheckType.Red, GenPos.Down)
            });
        };
        System.Func<Pattern> Finale3 = () =>
        {
            return new Pattern(new List<Note> {
                new Note(0, NoteType.One, CheckType.Blue, GenPos.Right),
                new Note(0, NoteType.One, CheckType.Green, GenPos.Right),
                new Note(0, NoteType.One, CheckType.Red, GenPos.Right)
            });
        };

		System.Func<Pattern> ChorusBaseLoop = () =>
        {
            return new Pattern(new List<Note> {
                new Note(0, NoteType.One, CheckType.Green, GenPos.Right),
                new Note(1.5f, NoteType.One, CheckType.Green, GenPos.Right),
                new Note(3, NoteType.One, CheckType.Green, GenPos.Right),
                new Note(4.5f, NoteType.One, CheckType.Green, GenPos.Right),
                new Note(6, NoteType.One, CheckType.Green, GenPos.Right),
                new Note(7, NoteType.One, CheckType.Red, GenPos.Right),

                new Note(8+0, NoteType.One, CheckType.Blue, GenPos.Right),
                new Note(8+1.5f, NoteType.One, CheckType.Blue, GenPos.Right),
                new Note(8+3, NoteType.One, CheckType.Blue, GenPos.Right),
                new Note(8+4.5f, NoteType.One, CheckType.Blue, GenPos.Right),
                new Note(8+6, NoteType.One, CheckType.Blue, GenPos.Right),
                new Note(8+7, NoteType.One, CheckType.Red, GenPos.Right),

                new Note(16+0, NoteType.One, CheckType.Green, GenPos.Right),
                new Note(16+1.5f, NoteType.One, CheckType.Green, GenPos.Right),
                new Note(16+3, NoteType.One, CheckType.Green, GenPos.Right),
                new Note(16+4.5f, NoteType.One, CheckType.Green, GenPos.Right),
                new Note(16+6, NoteType.One, CheckType.Green, GenPos.Right),
                new Note(16+7, NoteType.One, CheckType.Red, GenPos.Right),

                new Note(24+0, NoteType.One, CheckType.Blue, GenPos.Right),
                new Note(24+1.5f, NoteType.One, CheckType.Blue, GenPos.Right),
                new Note(24+3, NoteType.One, CheckType.Blue, GenPos.Right),
                new Note(24+4.5f, NoteType.One, CheckType.Blue, GenPos.Right),
                new Note(24+6, NoteType.One, CheckType.Red, GenPos.Right)
            });
        };
        
		System.Func<Pattern> ChorusMain = () =>
        {
			return new Pattern(new List<Note> {
                new Note(0, NoteType.One, CheckType.Blue, GenPos.Left),
				new Note(0.5f, NoteType.One, CheckType.Green, GenPos.Left),
				new Note(1, NoteType.One, CheckType.Red, GenPos.Left),
				new Note(2, NoteType.One, CheckType.Green, GenPos.Left),
				new Note(2.5f, NoteType.One, CheckType.Red, GenPos.Left),
				new Note(3.5f, NoteType.One, CheckType.Green, GenPos.Left),
				new Note(4, NoteType.One, CheckType.Red, GenPos.Left),
				new Note(5, NoteType.One, CheckType.Green, GenPos.Left),
				new Note(5.5f, NoteType.One, CheckType.Red, GenPos.Left),
				new Note(6.5f, NoteType.One, CheckType.Green, GenPos.Left),
				new Note(7f, NoteType.One, CheckType.Red, GenPos.Left),
            });
        };

		System.Func<Pattern> ChorusSub = () =>
        {
			return new Pattern(new List<Note> {
                new Note(0, NoteType.One, CheckType.Blue, GenPos.Down),
				new Note(0.5f, NoteType.One, CheckType.Green, GenPos.Down),
				new Note(1.5f, NoteType.One, CheckType.Blue, GenPos.Down),
				new Note(2, NoteType.One, CheckType.Red, GenPos.Down),
				new Note(3, NoteType.One, CheckType.Blue, GenPos.Down),
				new Note(3.5f, NoteType.One, CheckType.Green, GenPos.Down),
				new Note(4.5f, NoteType.One, CheckType.Blue, GenPos.Down),
				new Note(5, NoteType.One, CheckType.Red, GenPos.Down),
				new Note(6, NoteType.One, CheckType.Green, GenPos.Down),
				new Note(7, NoteType.One, CheckType.Red, GenPos.Down)
            });
        };

		System.Func<Pattern> ChorusMelody = () =>
        {
            return new Pattern(new List<Note> {
				new Note(0, NoteType.One, CheckType.Blue, GenPos.Down),
                new Note(4, NoteType.One, CheckType.Green, GenPos.Down),
                new Note(8, NoteType.One, CheckType.Red, GenPos.Down),
                new Note(12, NoteType.One, CheckType.Blue, GenPos.Down),
                new Note(16, NoteType.One, CheckType.Red, GenPos.Down),
                new Note(20, NoteType.One, CheckType.Green, GenPos.Down),
                new Note(24, NoteType.One, CheckType.Green, GenPos.Down),
                new Note(24, NoteType.One, CheckType.Blue, GenPos.Down),
                new Note(28, NoteType.One, CheckType.Blue, GenPos.Down),
                new Note(30, NoteType.One, CheckType.Red, GenPos.Down),
                new Note(32, NoteType.One, CheckType.Green, GenPos.Down),
                new Note(36, NoteType.One, CheckType.Blue, GenPos.Down),
                new Note(32+8, NoteType.One, CheckType.Blue, GenPos.Down),
                new Note(32+12, NoteType.One, CheckType.Green, GenPos.Down),
                new Note(32+16, NoteType.One, CheckType.Red, GenPos.Down),
                new Note(32+20, NoteType.One, CheckType.Green, GenPos.Down),
                new Note(32+24, NoteType.One, CheckType.Red, GenPos.Down),
                new Note(32+24, NoteType.One, CheckType.Blue, GenPos.Down),
                new Note(32+28, NoteType.One, CheckType.Green, GenPos.Down),
                new Note(32+30, NoteType.One, CheckType.Red, GenPos.Down)
            });
        };
        


        _sheet1 = new List<Action>();
        _sheet2 = new List<Action>();
        _sheet3 = new List<Action>();

		int i;
        
        for (i = 0; i < 18; i++)
            _sheet1.Add(new Action(8 + i * 8, FirstMelody()));
  
		for (i = 0; i < 11; i++)
			_sheet2.Add(new Action(8 + i * 8, SubMelody()));

		_sheet2.Add(new Action(96, SubInterludeMelody()));

        for (i = 0; i < 5; i++)
            _sheet3.Add(new Action(32 + (i * 32), BaseLoop()));
      
        /// 192부터 후렴
        for (i = 0; i < 4; i++)
            _sheet3.Add(new Action(192 + (i * 32), ChorusBaseLoop()));

		for (i = 0; i < 16; i++)
			_sheet1.Add(new Action(192 + (i * 8), ChorusMain()));

		for (i = 0; i < 8; i++)
			_sheet2.Add(new Action(192 + (i * 8), ChorusSub()));
		_sheet2.Add(new Action(256, ChorusMelody()));
		


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
		_sheet1.Add(new Action(320, Finale1()));
		_sheet2.Add(new Action(320, Finale2()));
        _sheet3.Add(new Action(320, Finale3()));

        _bpm = 160.0f;
    }
}