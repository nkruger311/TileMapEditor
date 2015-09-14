using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TileMapEditor
{
  public partial class SongismPictureBox : PictureBox
  {
    private string _sName = "";
    private bool _bDiscovered = false;
    private Vector2 _vMapPosition = Vector2.Zero;
    private Vector2 _vBoundingBoxDimensions = Vector2.Zero;
    private Vector2 _vBoundingBoxPosition = Vector2.Zero;
    private string _sState = "";
    private string _sAlbumName = "";
    private string _sSongInfo = "";
    private bool _bHasPrerequisiteSongism = false;
    private string _sPrerequisiteSongism = "";
    private bool _bHasPrerequisiteInventoryItem = false;
    private string _sPrerequisiteInventoryItem = "";

    [SongismPropertyAttribute]
    public new string Name { get { return _sName; } set { _sName = value; } }
    [SongismPropertyAttribute]
    public bool Discovered { get { return _bDiscovered; } set { _bDiscovered = value; } }
    [SongismPropertyAttribute]
    public Vector2 MapPosition { get { return _vMapPosition; } set { _vMapPosition = value; } }
    [SongismPropertyAttribute]
    public Vector2 BoundingBoxDimenions { get { return _vBoundingBoxDimensions; } set { _vBoundingBoxDimensions = value; } }
    [SongismPropertyAttribute]
    public Vector2 BoundingBoxPosition { get { return _vBoundingBoxPosition; } set { _vBoundingBoxPosition = value; } }
    [SongismPropertyAttribute]
    public string State { get { return _sState; } set { _sState = value; } }
    [SongismPropertyAttribute]
    public string AlbumName { get { return _sAlbumName; } set { _sAlbumName = value; } }
    [SongismPropertyAttribute]
    public string SongInfo { get { return _sSongInfo; } set { _sSongInfo = value; } }
    [SongismPropertyAttribute]
    public bool HasPrerequisiteSongism { get { return _bHasPrerequisiteSongism; } set { _bHasPrerequisiteSongism = value; } }
    [SongismPropertyAttribute]
    public string PrerequisiteSongism { get { return _sPrerequisiteSongism; } set { _sPrerequisiteSongism = value; } }
    [SongismPropertyAttribute]
    public bool HasPrerequisiteInventoryItem { get { return _bHasPrerequisiteInventoryItem; } set { _bHasPrerequisiteInventoryItem = value; } }
    [SongismPropertyAttribute]
    public string PrerequisiteInventoryItem { get { return _sPrerequisiteInventoryItem; } set { _sPrerequisiteInventoryItem = value; } }

    public SongismPictureBox()
    {
      InitializeComponent();
    }

    public SongismPictureBox(IContainer container)
    {
      container.Add(this);

      InitializeComponent();
    }
  }

  public class Image
  {
    private float _fAlpha;
    private string _sFontName;
    private string _sPath;
    private string _sTextAlignment;
    private Vector2 _vPosition;
    private float _fScale;
    private Rectangle _rectSourceRect;
    private bool _bIsActive;
    private string _sEffects;
    private FadeEffect _oFadeEffect;
    private SpriteSheetEffect _oSpriteSheetEffect;

    public float Alpha { get { return _fAlpha; } set { _fAlpha = value; } }
    public string FontName { get { return _sFontName; } set { _sFontName = value; } }
    public string Path { get { return _sPath; } set { _sPath = value; } }
    public string TextAlignment { get { return _sTextAlignment; } set { _sTextAlignment = value; } }
    public Vector2 Position { get { return _vPosition; } set { _vPosition = value; } }
    public float Scale { get { return _fScale; } set { _fScale = value; } }
    public Rectangle SourceRect { get { return _rectSourceRect; } set { _rectSourceRect = value; } }
    public bool IsActive { get { return _bIsActive; } set { _bIsActive = value; } }
    public string Effects { get { return _sEffects; } set { _sEffects = value; } }
    public FadeEffect FadeEffect { get { return _oFadeEffect; } set { _oFadeEffect = value; } }
    public SpriteSheetEffect SpriteSheetEffect { get { return _oSpriteSheetEffect; } set { _oSpriteSheetEffect = value; } }
  }

  public class Vector2
  {
    private float _fX;
    private float _fY;

    public static Vector2 Zero { get { return new Vector2(0.0f, 0.0f); } }

    public float X { get { return _fX; } set { _fX = value; } }

    public float Y { get { return _fY; } set { _fY = value; } }

    private Vector2(float x, float y)
    {
      _fX = x;
      _fY = y;
    }
  }

  public class FadeEffect
  {
    private bool _bIsActive;
    private float _fFadeSpeed;
    private bool _bIncrease;

    public bool IsActive { get { return _bIsActive; } set { _bIsActive = value; } }

    public float FadeSpeed { get { return _fFadeSpeed; } set { _fFadeSpeed = value; } }

    public bool Increase { get { return _bIncrease; } set { _bIncrease = value; } }
  }

  public class SpriteSheetEffect
  {
    private bool _bIsActive;
    private int _iFrameCounter;
    private int _iSwitchFrame;
    private Vector2 _vCurrentFrame;
    private Vector2 _vAmountOfFrames;
    private Vector2 _vDefaultFrame;

    public bool IsActive { get { return _bIsActive; } set { _bIsActive = value; } }

    public int FrameCounter { get { return _iFrameCounter; } set { _iFrameCounter = value; } }

    public int SwitchFrame { get { return _iSwitchFrame; } set { _iSwitchFrame = value; } }

    public Vector2 CurrentFrame { get { return _vCurrentFrame; } set { _vCurrentFrame = value; } }

    public Vector2 AmountOfFrames { get { return _vAmountOfFrames; } set { _vAmountOfFrames = value; } }

    public Vector2 DefaultFrame { get { return _vDefaultFrame; } set { _vDefaultFrame = value; } }
  }

}
