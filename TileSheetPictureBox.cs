using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TileMapEditor
{
  class TileSheetPictureBox : PictureBox
  {
    private Globals.TileType _eTileType = Globals.TileType.Regular;
    private int _iMapRowIndex = -1;
    private int _iMapColumnIndex = -1;

    private int _iTileSheetRowIndex = -1;
    private int _iTileSheetColumnIndex = -1;

    private bool _fHighlight = false;

    public Globals.TileType TileType
    {
      get { return _eTileType; }
      set { _eTileType = value; }
    }

    public int MapRowIndex
    {
      get { return _iMapRowIndex; }
      set { _iMapRowIndex = value; }
    }

    public int MapColumnIndex
    {
      get { return _iMapColumnIndex; }
      set { _iMapColumnIndex = value; }
    }

    public int TileSheetRowIndex
    {
      get { return _iTileSheetRowIndex; }
      set { _iTileSheetRowIndex = value; }
    }

    public int TileSheetColumnIndex
    {
      get { return _iTileSheetColumnIndex; }
      set { _iTileSheetColumnIndex = value; }
    }

    public bool Highlight
    {
      get { return _fHighlight; }
      set { _fHighlight = value; }
    }

    protected override void OnPaint(PaintEventArgs pe)
    {
      base.OnPaint(pe);

      if (_fHighlight)
      {
        switch (_eTileType)
        {
          case Globals.TileType.Regular:
            //ControlPaint.DrawBorder(pe.Graphics, pe.ClipRectangle, Color.Red, ButtonBorderStyle.Solid);
            ControlPaint.DrawBorder(pe.Graphics, pe.ClipRectangle, Color.DarkGreen, 1, ButtonBorderStyle.Solid, Color.DarkGreen, 1, ButtonBorderStyle.Solid, Color.DarkGreen, 1, ButtonBorderStyle.Solid, Color.DarkGreen, 1, ButtonBorderStyle.Solid);
            //ControlPaint.DrawBorder3D(pe.Graphics, pe.ClipRectangle, Border3DStyle.Raised, Border3DSide.All);
            break;

          case Globals.TileType.Solid:
            ControlPaint.DrawBorder(pe.Graphics, pe.ClipRectangle, Color.Red, ButtonBorderStyle.Solid);
            break;

          case Globals.TileType.Overlay:
            ControlPaint.DrawBorder(pe.Graphics, pe.ClipRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
            break;
        }
      }
    }
  }
}
