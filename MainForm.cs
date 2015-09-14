using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TileMapEditor
{
  public partial class MainForm : Form
  {

    #region Variables

    private string _sTileSheetFilePath = string.Empty;

    private int _iTileSheetTileHeight = 64;
    private int _iTileSheetTileWidth = 64;

    private int _iTileSheetRowCount = 1;
    private int _iTileSheetColumnCount = 0;

    private int _iTileSheetRowIndex = 0;
    private int _iTileSheetColumnIndex = 0;

    private int _iMapTileHeight = 64;
    private int _iMapTileWidth = 64;

    private int _iMapRowCount = 8;
    private int _iMapColumnCount = 8;

    private int _iPrevMapRowCount;
    private int _iPrevMapColumnCount;

    private const int MAX_TILE_SHEET_HEIGHT = 4906;
    private const int MAX_TILE_SHEET_WIDTH = 4096;

    private TileSheetPictureBox _pbTileActionPending = null;

    private List<int> _liSelectedMapTileIndices;

    protected SongismPictureBox _pbDragging;
    protected Point _ptPreviousLocation;

    #endregion // Variables

    #region Constructor

    public MainForm()
    {
      InitializeComponent();

      _liSelectedMapTileIndices = new List<int>();

      nudTileSheetTileHeight.Value = _iTileSheetTileHeight;
      nudTileSheetTileWidth.Value = _iTileSheetTileWidth;

      nudMapTileHeight.Value = _iMapTileHeight;
      nudMapTileWidth.Value = _iMapTileWidth;

      nudMapRowCount.Value = _iMapRowCount;
      nudMapColumnCount.Value = _iMapColumnCount;

      _iPrevMapRowCount = _iMapRowCount;
      _iPrevMapColumnCount = _iMapColumnCount;

      DrawTileMapGrid();
    }

    #endregion // Constructor

    #region Helper Methods

    private void AddColumnToMapGrid()
    {
      for (int iRowIndex = 0; iRowIndex < _iMapRowCount; iRowIndex++)
      {
        for (int iColumnIndex = _iPrevMapColumnCount; iColumnIndex < _iMapColumnCount; iColumnIndex++)
        {
          TileSheetPictureBox pbMapTile = new TileSheetPictureBox();
          pnlTileMap.Controls.Add(pbMapTile);

          pbMapTile.ContextMenuStrip = cmsMapMenu;
          pbMapTile.Size = new Size(_iMapTileWidth, _iMapTileHeight);
          pbMapTile.SizeMode = PictureBoxSizeMode.StretchImage;
          pbMapTile.BorderStyle = BorderStyle.FixedSingle;
          pbMapTile.Padding = new Padding(0);

          pbMapTile.Location = new Point((iColumnIndex * _iMapTileWidth) + 3, (iRowIndex * _iMapTileHeight) + 3);
          pbMapTile.MapRowIndex = iRowIndex;
          pbMapTile.MapColumnIndex = iColumnIndex;

          pbMapTile.Click += pbMapTile_Click;
        }
      }
    }

    private void AddRowToMapGrid()
    {
      for (int iRowIndex = _iPrevMapRowCount; iRowIndex < _iMapRowCount; iRowIndex++)
      {
        for (int iColumnIndex = 0; iColumnIndex < _iMapColumnCount; iColumnIndex++)
        {
          TileSheetPictureBox pbMapTile = new TileSheetPictureBox();
          pnlTileMap.Controls.Add(pbMapTile);

          pbMapTile.ContextMenuStrip = cmsMapMenu;
          pbMapTile.Size = new Size(_iMapTileWidth, _iMapTileHeight);
          pbMapTile.SizeMode = PictureBoxSizeMode.StretchImage;
          pbMapTile.BorderStyle = BorderStyle.FixedSingle;
          pbMapTile.Padding = new Padding(0);

          pbMapTile.Location = new Point((iColumnIndex * _iMapTileWidth) + 3, (iRowIndex * _iMapTileHeight) + 3);
          pbMapTile.MapRowIndex = iRowIndex;
          pbMapTile.MapColumnIndex = iColumnIndex;

          pbMapTile.Click += pbMapTile_Click;
        }
      }
    }

    private void CopyTileSheetTile(Globals.TileType newType)
    {
      int iControlIndex = 0;
      for (iControlIndex = 0; iControlIndex < _pbTileActionPending.Parent.Controls.Count; iControlIndex++)
      {
        if (Control.Equals(_pbTileActionPending.Parent.Controls[iControlIndex], _pbTileActionPending))
        {
          break;
        }
      }

      TileSheetPictureBox pbNewTile = new TileSheetPictureBox();
      pbNewTile.Size = new Size(64, 64);
      pbNewTile.SizeMode = PictureBoxSizeMode.StretchImage;
      pbNewTile.Image = _pbTileActionPending.Image;

      _iTileSheetColumnIndex++;

      if ((_iTileSheetColumnIndex * _iTileSheetTileWidth) >= MAX_TILE_SHEET_WIDTH)
      {
        _iTileSheetColumnCount = _iTileSheetColumnIndex - 1;

        /* Reset the column index */
        _iTileSheetColumnIndex = 0;
        _iTileSheetRowIndex++;
      }

      if ((_iTileSheetRowIndex * _iTileSheetTileHeight) > MAX_TILE_SHEET_HEIGHT)
      {
        throw new ArgumentOutOfRangeException("Tile Sheet exceeds maximum size.");
      }

      pbNewTile.Tag = new Rectangle((_iTileSheetColumnIndex * _iTileSheetTileWidth), (_iTileSheetRowIndex * _iTileSheetTileHeight), _iTileSheetTileWidth, _iTileSheetTileHeight);
      pbNewTile.TileSheetColumnIndex = _iTileSheetColumnIndex;
      pbNewTile.TileSheetRowIndex = _iTileSheetRowIndex;

      pbNewTile.ContextMenuStrip = cmsTileSheetMenu;
      pbNewTile.TileType = newType;

      switch (newType)
      {
        case Globals.TileType.Regular:
          pbNewTile.Click += pbRegularTile_Click;
          flpRegularTiles.Controls.Add(pbNewTile);
          break;

        case Globals.TileType.Solid:
          pbNewTile.Click += pbSolidTile_Click;
          flpSolidTiles.Controls.Add(pbNewTile);
          break;

        case Globals.TileType.Overlay:
          pbNewTile.Click += pbOverlayTile_Click;
          flpOverlayTiles.Controls.Add(pbNewTile);
          break;
      }
    }

    private void DrawTileMapGrid()
    {
      for (int iRowIndex = 0; iRowIndex < _iMapRowCount; iRowIndex++)
      {
        for (int iColumnIndex = 0; iColumnIndex < _iMapColumnCount; iColumnIndex++)
        {
          TileSheetPictureBox pbMapTile = new TileSheetPictureBox();
          pnlTileMap.Controls.Add(pbMapTile);

          pbMapTile.ContextMenuStrip = cmsMapMenu;
          pbMapTile.Size = new Size(_iMapTileWidth, _iMapTileHeight);
          pbMapTile.SizeMode = PictureBoxSizeMode.StretchImage;
          pbMapTile.BorderStyle = BorderStyle.FixedSingle;
          pbMapTile.Padding = new Padding(0);

          pbMapTile.Location = new Point((iColumnIndex * _iMapTileWidth) + 3, (iRowIndex * _iMapTileHeight) + 3);
          pbMapTile.MapRowIndex = iRowIndex;
          pbMapTile.MapColumnIndex = iColumnIndex;

          pbMapTile.Click += pbMapTile_Click;
        }

      }
    }

    private void ClearTileSheetTiles()
    {
      flpRegularTiles.Controls.Clear();
      flpSolidTiles.Controls.Clear();
      flpOverlayTiles.Controls.Clear();
    }

    private void LoadTileSheet(string fileName)
    {
      ClearTileSheetTiles();
      _sTileSheetFilePath = fileName;
      System.Drawing.Image imgTileSheet = Bitmap.FromFile(_sTileSheetFilePath);

      int iRowCount = imgTileSheet.Height / _iTileSheetTileHeight;
      int iColumnCount = imgTileSheet.Width / _iTileSheetTileWidth;

      nudTileSheetRowCount.Value = iRowCount;
      nudTileSheetColumnCount.Value = iColumnCount;

      _iTileSheetRowIndex = iRowCount;
      _iTileSheetColumnIndex = iColumnCount;

      for (int iRowIndex = 0; iRowIndex < iRowCount; iRowIndex++)
      {
        for (int iColumnIndex = 0; iColumnIndex < iColumnCount; iColumnIndex++)
        {
          TileSheetPictureBox pbRegularTile = new TileSheetPictureBox();
          Rectangle rectCroppedImage = new Rectangle(0, 0, _iTileSheetTileWidth, _iTileSheetTileHeight);
          Rectangle rectSource = new Rectangle((iColumnIndex * _iTileSheetTileWidth), (iRowIndex * _iTileSheetTileHeight), _iTileSheetTileWidth, _iTileSheetTileHeight);

          Bitmap target = new Bitmap(_iTileSheetTileWidth, _iTileSheetTileHeight);

          using (Graphics g = Graphics.FromImage(target))
          {
            g.DrawImage(imgTileSheet, rectCroppedImage, rectSource, GraphicsUnit.Pixel);
          }


          pbRegularTile.Size = new Size(64, 64);
          pbRegularTile.SizeMode = PictureBoxSizeMode.StretchImage;
          pbRegularTile.Image = target;
          pbRegularTile.Tag = rectSource;
          pbRegularTile.TileSheetColumnIndex = iColumnIndex;
          pbRegularTile.TileSheetRowIndex = iRowIndex;

          flpRegularTiles.Controls.Add(pbRegularTile);

          pbRegularTile.Click += pbRegularTile_Click;
          pbRegularTile.ContextMenuStrip = cmsTileSheetMenu;
        }
      }
    }

    private void MoveTileSheetTile(Globals.TileType newType)
    {
      int iControlIndex = 0;
      for (iControlIndex = 0; iControlIndex < _pbTileActionPending.Parent.Controls.Count; iControlIndex++)
      {
        if (Control.Equals(_pbTileActionPending.Parent.Controls[iControlIndex], _pbTileActionPending))
        {
          break;
        }
      }

      UpdateMapTileType(newType);

      TileSheetPictureBox pbNewTile = new TileSheetPictureBox();
      pbNewTile.Size = new Size(64, 64);
      pbNewTile.SizeMode = PictureBoxSizeMode.StretchImage;
      pbNewTile.Tag = ((TileSheetPictureBox)_pbTileActionPending.Parent.Controls[iControlIndex]).Tag;
      pbNewTile.Image = _pbTileActionPending.Image;
      pbNewTile.TileType = newType;
      pbNewTile.TileSheetColumnIndex = ((TileSheetPictureBox)_pbTileActionPending.Parent.Controls[iControlIndex]).TileSheetColumnIndex;
      pbNewTile.TileSheetRowIndex = ((TileSheetPictureBox)_pbTileActionPending.Parent.Controls[iControlIndex]).TileSheetRowIndex;
      pbNewTile.ContextMenuStrip = cmsTileSheetMenu;

      _pbTileActionPending.Parent.Controls.RemoveAt(iControlIndex);

      switch (newType)
      {
        case Globals.TileType.Regular:
          pbNewTile.Click += pbRegularTile_Click;
          flpRegularTiles.Controls.Add(pbNewTile);
          break;

        case Globals.TileType.Solid:
          pbNewTile.Click += pbSolidTile_Click;
          flpSolidTiles.Controls.Add(pbNewTile);
          break;

        case Globals.TileType.Overlay:
          pbNewTile.Click += pbOverlayTile_Click;
          flpOverlayTiles.Controls.Add(pbNewTile);
          break;
      }
    }

    private void RemoveColumnFromMapGrid()
    {
      List<int> liInidicesToRemove = new List<int>();

      foreach (Control oControl in pnlTileMap.Controls)
      {
        if (((TileSheetPictureBox)oControl).MapColumnIndex >= _iMapColumnCount)
        {
          liInidicesToRemove.Add(pnlTileMap.Controls.IndexOf(((TileSheetPictureBox)oControl)));
        }
      }

      liInidicesToRemove.Reverse();

      foreach (int iIndex in liInidicesToRemove)
      {
        pnlTileMap.Controls.RemoveAt(iIndex);
      }
    }

    private void RemoveRowFromMapGrid()
    {
      List<int> liInidicesToRemove = new List<int>();

      foreach (Control oControl in pnlTileMap.Controls)
      {
        if (((TileSheetPictureBox)oControl).MapRowIndex >= _iMapRowCount)
        {
          liInidicesToRemove.Add(pnlTileMap.Controls.IndexOf(((TileSheetPictureBox)oControl)));
        }
      }

      liInidicesToRemove.Reverse();

      foreach (int iIndex in liInidicesToRemove)
      {
        pnlTileMap.Controls.RemoveAt(iIndex);
      }
    }

    private void ResizeTileHeight()
    {
      TileSheetPictureBox pbTile;
      foreach (Control oControl in pnlTileMap.Controls)
      {
        pbTile = (TileSheetPictureBox)oControl;

        pbTile.Height = _iMapTileHeight;
        pbTile.Location = new Point((pbTile.MapColumnIndex * _iMapTileWidth) + 3, (pbTile.MapRowIndex * _iMapTileHeight) + 3);
      }
    }

    private void ResizeTileWidth()
    {
      TileSheetPictureBox pbTile;
      foreach (Control oControl in pnlTileMap.Controls)
      {
        pbTile = (TileSheetPictureBox)oControl;

        pbTile.Width = _iMapTileWidth;
        pbTile.Location = new Point((pbTile.MapColumnIndex * _iMapTileWidth) + 3, (pbTile.MapRowIndex * _iMapTileHeight) + 3);
      }
    }

    private void WriteToXml()
    {
      //<?xml version=\"1.0\" encoding=\"utf-8\"?>

      SaveFileDialog dlgSaveFile = new SaveFileDialog();
      dlgSaveFile.Filter = "XML Files|*.xml";

      if (dlgSaveFile.ShowDialog(this) == DialogResult.OK)
      {
        TileSheetPictureBox pbTile = null;

        using (FileStream fs = new FileStream(dlgSaveFile.FileName, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
        {
          using (StreamWriter sw = new StreamWriter(fs))
          {
            sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            sw.WriteLine("<Map>");
            sw.WriteLine("  <Layer>");
            sw.WriteLine("    <Image>");
            sw.WriteLine(String.Format("      <Path>Gameplay/TileSheets/{0}</Path>", txtMapName.Text.Trim()));
            sw.WriteLine("    </Image>");

            sw.Write("    <SolidTiles>");

            foreach (Control oControl in flpSolidTiles.Controls)
            {
              pbTile = (TileSheetPictureBox)oControl;
              sw.Write(String.Format("[{0}:{1}]", pbTile.TileSheetColumnIndex, pbTile.TileSheetRowIndex));
            }

            sw.WriteLine("</SolidTiles>");

            sw.Write("    <OverlayTiles>");

            foreach (Control oControl in flpOverlayTiles.Controls)
            {
              pbTile = (TileSheetPictureBox)oControl;
              sw.Write(String.Format("[{0}:{1}]", pbTile.TileSheetColumnIndex, pbTile.TileSheetRowIndex));
            }

            sw.WriteLine("</OverlayTiles>");

            sw.WriteLine("    <TileMap>");


            for (int iRowIndex = 0; iRowIndex < _iMapRowCount; iRowIndex++)
            {
              sw.Write("      <Row>");

              for (int iColumnIndex = 0; iColumnIndex < _iMapColumnCount; iColumnIndex++)
              {
                foreach (Control oControl in pnlTileMap.Controls)
                {
                  pbTile = (TileSheetPictureBox)oControl;
                  if (pbTile.MapRowIndex == iRowIndex && pbTile.MapColumnIndex == iColumnIndex)
                  {
                    sw.Write(String.Format("[{0}:{1}]", pbTile.TileSheetColumnIndex, pbTile.TileSheetRowIndex));
                    break;
                  }
                }
              }

              sw.WriteLine("</Row>");
            }

            sw.WriteLine("    </TileMap>");

            sw.WriteLine("    <TileDimensions>");
            sw.WriteLine(String.Format("      <X>{0}</X>", _iMapTileWidth.ToString()));
            sw.WriteLine(String.Format("      <Y>{0}</Y>", _iMapTileHeight.ToString()));
            sw.WriteLine("    </TileDimensions>");

            sw.WriteLine("  </Layer>");
            sw.WriteLine("</Map>");
          }
        }
      }
    }

    #endregion // Helper Methods

    #region Events

    private void btnRefreshGrid_Click(object sender, EventArgs e)
    {
      //DrawTileMapGrid();
      pnlTileMap.Refresh();
    }

    private void cmsTileSheetMenu_Opening(object sender, CancelEventArgs e)
    {
      _pbTileActionPending = (TileSheetPictureBox)((ContextMenuStrip)sender).SourceControl;
      switch (_pbTileActionPending.TileType)
      {
        case Globals.TileType.Regular:
          tsmiMoveToRegular.Enabled = false;
          tsmiMoveToSolid.Enabled = true;
          tsmiMoveToOverlay.Enabled = true;

          tsmiCopyToRegular.Enabled = false;
          tsmiCopyToSolid.Enabled = true;
          tsmiCopyToOverlay.Enabled = true;

          break;
        case Globals.TileType.Solid:
          tsmiMoveToRegular.Enabled = true;
          tsmiMoveToSolid.Enabled = false;
          tsmiMoveToOverlay.Enabled = true;

          tsmiCopyToRegular.Enabled = true;
          tsmiCopyToSolid.Enabled = false;
          tsmiCopyToOverlay.Enabled = true;

          break;
        case Globals.TileType.Overlay:
          tsmiMoveToRegular.Enabled = true;
          tsmiMoveToSolid.Enabled = true;
          tsmiMoveToOverlay.Enabled = false;

          tsmiCopyToRegular.Enabled = true;
          tsmiCopyToSolid.Enabled = true;
          tsmiCopyToOverlay.Enabled = false;

          break;
      }
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (MessageBox.Show("Are you sure you want to leave?", "Tile Map Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
      {
        e.Cancel = true;
      }
    }

    private void pbMapTile_Click(object sender, EventArgs e)
    {
      TileSheetPictureBox pbMapTile = (TileSheetPictureBox)sender;
      if (pbSelectedTile.Image != null)
      {
        pbMapTile.Image = pbSelectedTile.Image;
        pbMapTile.TileSheetColumnIndex = pbSelectedTile.TileSheetColumnIndex;
        pbMapTile.TileSheetRowIndex = pbSelectedTile.TileSheetRowIndex;
        pbMapTile.Tag = pbSelectedTile.Tag;
        pbMapTile.TileType = pbSelectedTile.TileType;
        pbMapTile.BorderStyle = BorderStyle.None;
      }
      else
      {
        if (ModifierKeys.Equals(Keys.Control))
        {
          int iIndex = pnlTileMap.Controls.IndexOf(pbMapTile);

          if (_liSelectedMapTileIndices.Contains(iIndex))
          {
            _liSelectedMapTileIndices.Remove(iIndex);
            pbMapTile.BorderStyle = BorderStyle.None;
          }
          else
          {
            _liSelectedMapTileIndices.Add(iIndex);
            pbMapTile.BorderStyle = BorderStyle.FixedSingle;
          }
        }
        else
        {
          int iIndex = pnlTileMap.Controls.IndexOf(pbMapTile);

          if (_liSelectedMapTileIndices.Contains(iIndex))
          {
            foreach (int iSelectedIndex in _liSelectedMapTileIndices)
            {
              ((TileSheetPictureBox)pnlTileMap.Controls[iSelectedIndex]).BorderStyle = BorderStyle.None;
            }

            _liSelectedMapTileIndices.Remove(iIndex);
            pbMapTile.BorderStyle = BorderStyle.None;
          }
          else
          {
            foreach (int iSelectedIndex in _liSelectedMapTileIndices)
            {
              ((TileSheetPictureBox)pnlTileMap.Controls[iSelectedIndex]).BorderStyle = BorderStyle.None;
            }

            _liSelectedMapTileIndices.Clear();
            _liSelectedMapTileIndices.Add(iIndex);
            pbMapTile.BorderStyle = BorderStyle.FixedSingle;
          }
        }
        
      }
    }

    private void pbOverlayTile_Click(object sender, EventArgs e)
    {
      foreach (Control oControl in flpOverlayTiles.Controls)
      {
        if (Control.Equals(oControl, sender))
        {
          pbSelectedTile.Image = ((TileSheetPictureBox)sender).Image;
          pbSelectedTile.Tag = ((TileSheetPictureBox)sender).Tag;
          pbSelectedTile.TileSheetColumnIndex = ((TileSheetPictureBox)sender).TileSheetColumnIndex;
          pbSelectedTile.TileSheetRowIndex = ((TileSheetPictureBox)sender).TileSheetRowIndex;
          pbSelectedTile.TileType = Globals.TileType.Overlay;

          break;
        }
      }
    }

    private void pbRegularTile_Click(object sender, EventArgs e)
    {
      foreach (Control oControl in flpRegularTiles.Controls)
      {
        if (Control.Equals(oControl, sender))
        {
          pbSelectedTile.Image = ((TileSheetPictureBox)sender).Image;
          pbSelectedTile.Tag = ((TileSheetPictureBox)sender).Tag;
          pbSelectedTile.TileSheetColumnIndex = ((TileSheetPictureBox)sender).TileSheetColumnIndex;
          pbSelectedTile.TileSheetRowIndex = ((TileSheetPictureBox)sender).TileSheetRowIndex;
          pbSelectedTile.TileType = Globals.TileType.Regular;

          break;
        }
      }
    }

    private void pbSolidTile_Click(object sender, EventArgs e)
    {
      foreach (Control oControl in flpSolidTiles.Controls)
      {
        if (Control.Equals(oControl, sender))
        {
          pbSelectedTile.Image = ((TileSheetPictureBox)sender).Image;
          pbSelectedTile.Tag = ((TileSheetPictureBox)sender).Tag;
          pbSelectedTile.TileSheetColumnIndex = ((TileSheetPictureBox)sender).TileSheetColumnIndex;
          pbSelectedTile.TileSheetRowIndex = ((TileSheetPictureBox)sender).TileSheetRowIndex;
          pbSelectedTile.TileType = Globals.TileType.Solid;

          break;
        }
      }
    }

    private void tsmiExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void tsmiImportTileSheet_Click(object sender, EventArgs e)
    {
      OpenFileDialog dlgLoadTileSheet = new OpenFileDialog();
      dlgLoadTileSheet.Filter = "PNG Files|*.png";

      if (dlgLoadTileSheet.ShowDialog(this) == DialogResult.OK)
      {
        LoadTileSheet(dlgLoadTileSheet.FileName);
      }
    }

    private void tsmiMoveToOverlay_Click(object sender, EventArgs e)
    {
      MoveTileSheetTile(Globals.TileType.Overlay);
    }

    private void tsmiMoveToRegular_Click(object sender, EventArgs e)
    {
      MoveTileSheetTile(Globals.TileType.Regular);
    }

    private void tsmiMoveToSolid_Click(object sender, EventArgs e)
    {
      MoveTileSheetTile(Globals.TileType.Solid);
    }

    #endregion // Events

    private void nudMapRowCount_ValueChanged(object sender, EventArgs e)
    {
      _iMapRowCount = (int)nudMapRowCount.Value;

      if (_iMapRowCount > _iPrevMapRowCount)
      {
        AddRowToMapGrid();
      }
      else
      {
        RemoveRowFromMapGrid();
      }

      _iPrevMapRowCount = _iMapRowCount;
    }

    private void nudMapColumnCount_ValueChanged(object sender, EventArgs e)
    {
      _iMapColumnCount = (int)nudMapColumnCount.Value;

      if (_iMapColumnCount > _iPrevMapColumnCount)
      {
        AddColumnToMapGrid();
      }
      else
      {
        RemoveColumnFromMapGrid();
      }

      _iPrevMapColumnCount = _iMapColumnCount;
    }

    private void nudTileHeight_ValueChanged(object sender, EventArgs e)
    {
      _iMapTileHeight = (int)nudMapTileHeight.Value;
      ResizeTileHeight();
    }

    private void nudTileWidth_ValueChanged(object sender, EventArgs e)
    {
      _iMapTileWidth = (int)nudMapTileWidth.Value;
      ResizeTileWidth();
    }

    private void tsmiImportMap_Click(object sender, EventArgs e)
    {
      OpenFileDialog dlgLoadTileSheet = new OpenFileDialog();
      dlgLoadTileSheet.Filter = "PNG Files|*.png";

      if (dlgLoadTileSheet.ShowDialog(this) == DialogResult.OK)
      {
        LoadMap(dlgLoadTileSheet.FileName);
      }
    }

    private void LoadMap(string fileName)
    {
      _sTileSheetFilePath = fileName.Replace(".png", "_TileSheet.png");
      System.Drawing.Image imgMap = Bitmap.FromFile(fileName);

      int iMapRowCount = imgMap.Height / _iMapTileHeight;
      int iMapColumnCount = imgMap.Width / _iMapTileWidth;

      if (iMapRowCount > nudMapRowCount.Value)
      {
        nudMapRowCount.Value = iMapRowCount;
      }

      if (iMapColumnCount > nudMapColumnCount.Value)
      {
        nudMapColumnCount.Value = iMapColumnCount;
      }

      for (int iMapRowIndex = 0; iMapRowIndex < iMapRowCount; iMapRowIndex++)
      {
        for (int iMapColumnIndex = 0; iMapColumnIndex < iMapColumnCount; iMapColumnIndex++)
        {
          Rectangle rectCroppedImage = new Rectangle(0, 0, _iMapTileWidth, _iMapTileHeight);
          Rectangle rectSource = new Rectangle((iMapColumnIndex * _iMapTileWidth), (iMapRowIndex * _iMapTileHeight), _iMapTileWidth, _iMapTileHeight);

          Bitmap target = new Bitmap(_iMapTileWidth, _iMapTileHeight);

          using (Graphics g = Graphics.FromImage(target))
          {
            g.DrawImage(imgMap, rectCroppedImage, rectSource, GraphicsUnit.Pixel);
          }

          foreach (TileSheetPictureBox pbMapTile in pnlTileMap.Controls)
          {
            if (pbMapTile.MapColumnIndex == iMapColumnIndex && pbMapTile.MapRowIndex == iMapRowIndex)
            {
              pbMapTile.Image = target;
              pbMapTile.Tag = rectSource;
              pbMapTile.BorderStyle = BorderStyle.None;
              break;
            }
          }
        }
      }

      CreateTileSheetControls();
    }

    private void CreateTileSheetControls()
    {
      int iRowIndex = 0;
      int iColumnIndex = 0;
      bool fAddToTileSheet = true;
      Rectangle rectTag;

      foreach (TileSheetPictureBox pbMapTile in pnlTileMap.Controls)
      {
        fAddToTileSheet = true;

        foreach (TileSheetPictureBox pbTileSheetTile in flpRegularTiles.Controls)
        {
          if (CompareImages((Bitmap)pbMapTile.Image, (Bitmap)pbTileSheetTile.Image))
          {
            pbMapTile.TileSheetColumnIndex = pbTileSheetTile.TileSheetColumnIndex;
            pbMapTile.TileSheetRowIndex = pbTileSheetTile.TileSheetRowIndex;
            pbMapTile.Tag = pbTileSheetTile.Tag;

            fAddToTileSheet = false;
            break;
          }
        }

        if (fAddToTileSheet)
        {
          _iTileSheetColumnIndex = iColumnIndex;
          _iTileSheetRowIndex = iRowIndex;

          pbMapTile.TileSheetColumnIndex = iColumnIndex;
          pbMapTile.TileSheetRowIndex = iRowIndex;

          rectTag = (Rectangle)pbMapTile.Tag;
          AddImageToTileSheet(pbMapTile.Image, ref rectTag, ref iRowIndex, ref iColumnIndex);
          pbMapTile.Tag = rectTag;
        }

        if (_iTileSheetRowCount == 1)
        {
          _iTileSheetColumnCount = iColumnIndex;
        }
      }
    }

    private void AddImageToTileSheet(System.Drawing.Image img, ref Rectangle tag, ref int rowIndex, ref int columnIndex)
    {
      TileSheetPictureBox pbRegularTile = new TileSheetPictureBox();
      
      pbRegularTile.Size = new Size(64, 64);
      pbRegularTile.SizeMode = PictureBoxSizeMode.StretchImage;
      pbRegularTile.Image = img;

      /* Reset the Tag property to match the tile sheet source rectangle */
      tag = new Rectangle((columnIndex * _iTileSheetTileWidth), (rowIndex * _iTileSheetTileHeight), _iTileSheetTileWidth, _iTileSheetTileHeight);
      pbRegularTile.Tag = tag;

      pbRegularTile.TileSheetColumnIndex = columnIndex;
      pbRegularTile.TileSheetRowIndex = rowIndex;

      flpRegularTiles.Controls.Add(pbRegularTile);

      pbRegularTile.Click += pbRegularTile_Click;
      pbRegularTile.ContextMenuStrip = cmsTileSheetMenu;


      columnIndex++;

      if ((columnIndex * _iTileSheetTileWidth) >= MAX_TILE_SHEET_WIDTH)
      {
        _iTileSheetColumnCount = columnIndex - 1;

        /* Reset the column index */
        columnIndex = 0;
        rowIndex++;

        _iTileSheetRowCount++;
      }

      if ((rowIndex * _iTileSheetTileHeight) > MAX_TILE_SHEET_HEIGHT)
      {
        _iTileSheetRowCount--;
        throw new ArgumentOutOfRangeException("Tile Sheet exceeds maximum size.");
      }
    }

    private bool CompareImages(Bitmap bmp1, Bitmap bmp2)
    {
      bool equals = true;
      Rectangle rect = new Rectangle(0, 0, bmp1.Width, bmp1.Height);
      int iWidthModifier = 4;

      switch (bmp1.PixelFormat)
      {
        case PixelFormat.Format24bppRgb:
          iWidthModifier = 3;
          break;

        case PixelFormat.Format32bppArgb:
          iWidthModifier = 4;
          break;

        default:
          throw new Exception("Pixel format not supported.");
      }

      BitmapData bmpData1 = bmp1.LockBits(rect, ImageLockMode.ReadOnly, bmp1.PixelFormat);
      BitmapData bmpData2 = bmp2.LockBits(rect, ImageLockMode.ReadOnly, bmp2.PixelFormat);

      unsafe
      {
        byte* ptr1 = (byte*)bmpData1.Scan0.ToPointer();
        byte* ptr2 = (byte*)bmpData2.Scan0.ToPointer();
        //int width = rect.Width * 3; // for 24bpp pixel data
        int width = rect.Width * iWidthModifier;

        for (int y = 0; equals && y < rect.Height; y++)
        {
          for (int x = 0; x < width; x++)
          {
            if (*ptr1 != *ptr2)
            {
              equals = false;
              break;
            }
            ptr1++;
            ptr2++;
          }
          ptr1 += bmpData1.Stride - width;
          ptr2 += bmpData2.Stride - width;
        }
      }
      bmp1.UnlockBits(bmpData1);
      bmp2.UnlockBits(bmpData2);

      return equals;
    }

    private void tsmiCopyToRegular_Click(object sender, EventArgs e)
    {
      CopyTileSheetTile(Globals.TileType.Regular);
    }

    private void tsmiCopyToSolid_Click(object sender, EventArgs e)
    {
      CopyTileSheetTile(Globals.TileType.Solid);
    }

    private void tsmiCopyToOverlay_Click(object sender, EventArgs e)
    {
      CopyTileSheetTile(Globals.TileType.Overlay);
    }

    private void tsmiExportTileSheet_Click(object sender, EventArgs e)
    {
      Bitmap target = new Bitmap((_iTileSheetColumnCount * _iTileSheetTileWidth), (_iTileSheetRowCount * _iTileSheetTileHeight));
      //Bitmap target2 = new Bitmap((_iTileSheetColumnCount * _iTileSheetTileWidth), (_iTileSheetRowCount * _iTileSheetTileHeight), PixelFormat.Format32bppArgb)

      using (Graphics g = Graphics.FromImage(target))
      {
        foreach (TileSheetPictureBox pbRegularTile in flpRegularTiles.Controls)
        {
          g.DrawImage(pbRegularTile.Image, (Rectangle)pbRegularTile.Tag, new Rectangle(0, 0, 64, 64), GraphicsUnit.Pixel);
        }

        foreach (TileSheetPictureBox pbSolidTile in flpSolidTiles.Controls)
        {
          g.DrawImage(pbSolidTile.Image, (Rectangle)pbSolidTile.Tag, new Rectangle(0, 0, 64, 64), GraphicsUnit.Pixel);
        }

        foreach (TileSheetPictureBox pbOverlayTile in flpOverlayTiles.Controls)
        {
          g.DrawImage(pbOverlayTile.Image, (Rectangle)pbOverlayTile.Tag, new Rectangle(0, 0, 64, 64), GraphicsUnit.Pixel);
        }
      }

      target.Save(_sTileSheetFilePath);
    }

    private void tsmiExportMap_Click(object sender, EventArgs e)
    {
      if (String.IsNullOrEmpty(txtMapName.Text))
      {
        MessageBox.Show("Enter a map name before proceeding.", "Tile Map Editor", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        return;
      }

      WriteToXml();
    }

    private void nudTileSheetTileHeight_ValueChanged(object sender, EventArgs e)
    {
      _iTileSheetTileHeight = (int)nudTileSheetTileHeight.Value;

      if (!string.IsNullOrEmpty(_sTileSheetFilePath))
      {
        LoadTileSheet(_sTileSheetFilePath);
      }
    }

    private void nudTileSheetTileWidth_ValueChanged(object sender, EventArgs e)
    {
      _iTileSheetTileWidth = (int)nudTileSheetTileWidth.Value;

      if (!string.IsNullOrEmpty(_sTileSheetFilePath))
      {
        LoadTileSheet(_sTileSheetFilePath);
      }
    }

    private void tsmiRemoveTile_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Are you sure you want to remove the selected tile?" + Environment.NewLine + "This operation cannot be undone.", "Tile Map Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
      {
        if (MessageBox.Show("Last chance to back out." + Environment.NewLine + "Are you sure you want to remove the selected tile?" + Environment.NewLine + "This operation cannot be undone.", "Tile Map Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
        {
          RemoveTile();
        }
      }
    }

    private void RemoveTile()
    {
        int iControlIndex = 0;
        for (iControlIndex = 0; iControlIndex < _pbTileActionPending.Parent.Controls.Count; iControlIndex++)
        {
            if (Control.Equals(_pbTileActionPending.Parent.Controls[iControlIndex], _pbTileActionPending))
            {
                break;
            }
        }

        _pbTileActionPending.Parent.Controls.RemoveAt(iControlIndex);
    }

    private void btnClearSelection_Click(object sender, EventArgs e)
    {
      pbSelectedTile.Image = null;
      pbSelectedTile.Tag = null;
    }

    private void cmsMapMenu_Opening(object sender, CancelEventArgs e)
    {
      if (_liSelectedMapTileIndices.Count > 0)
      {
        bool fMoveMapTileToRegularEnabled = true;
        bool fMoveMapTileToSolidEnabled = true;
        bool fMoveMapTileToOverlayEnabled = true;

        bool fCopyMapTileToRegularEnabled = true;
        bool fCopyMapTileToSolidEnabled = true;
        bool fCopyMapTileToOverlayEnabled = true;

        TileSheetPictureBox pbMapTile;
        foreach (int iSelectedIndex in _liSelectedMapTileIndices)
        {
          pbMapTile = (TileSheetPictureBox)pnlTileMap.Controls[iSelectedIndex];

          switch (pbMapTile.TileType)
          {
            case Globals.TileType.Regular:
              fMoveMapTileToRegularEnabled = false;
              fCopyMapTileToRegularEnabled = false;
              break;

            case Globals.TileType.Solid:
              fMoveMapTileToSolidEnabled = false;
              fCopyMapTileToSolidEnabled = false;
              break;

            case Globals.TileType.Overlay:
              fMoveMapTileToOverlayEnabled = false;
              fCopyMapTileToOverlayEnabled = false;
              break;

            default:
              throw new ArgumentOutOfRangeException("TileType not currently supported.");
          }
        }

        tsmiMoveMapTileToRegular.Enabled = fMoveMapTileToRegularEnabled;
        tsmiMoveMapTileToSolid.Enabled = fMoveMapTileToSolidEnabled;
        tsmiMoveMapTileToOverlay.Enabled = fMoveMapTileToOverlayEnabled;

        tsmiCopyMapTileToRegular.Enabled = fCopyMapTileToRegularEnabled;
        tsmiCopyMapTileToSolid.Enabled = fCopyMapTileToSolidEnabled;
        tsmiCopyMapTileToOverlay.Enabled = fCopyMapTileToOverlayEnabled;
      }
      else
      {
        _pbTileActionPending = (TileSheetPictureBox)((ContextMenuStrip)sender).SourceControl;
        switch (_pbTileActionPending.TileType)
        {
          case Globals.TileType.Regular:
            tsmiMoveMapTileToRegular.Enabled = false;
            tsmiMoveMapTileToSolid.Enabled = true;
            tsmiMoveMapTileToOverlay.Enabled = true;

            tsmiCopyMapTileToRegular.Enabled = false;
            tsmiCopyMapTileToSolid.Enabled = true;
            tsmiCopyMapTileToOverlay.Enabled = true;

            break;
          case Globals.TileType.Solid:
            tsmiMoveMapTileToRegular.Enabled = true;
            tsmiMoveMapTileToSolid.Enabled = false;
            tsmiMoveMapTileToOverlay.Enabled = true;

            tsmiCopyMapTileToRegular.Enabled = true;
            tsmiCopyMapTileToSolid.Enabled = false;
            tsmiCopyMapTileToOverlay.Enabled = true;

            break;
          case Globals.TileType.Overlay:
            tsmiMoveMapTileToRegular.Enabled = true;
            tsmiMoveMapTileToSolid.Enabled = true;
            tsmiMoveMapTileToOverlay.Enabled = false;

            tsmiCopyMapTileToRegular.Enabled = true;
            tsmiCopyMapTileToSolid.Enabled = true;
            tsmiCopyMapTileToOverlay.Enabled = false;

            break;
        }
      }
    }

    private void UpdateMapTileType(Globals.TileType type)
    {
      foreach (TileSheetPictureBox pbMapTile in pnlTileMap.Controls)
      {
        if (pbMapTile.TileSheetColumnIndex == _pbTileActionPending.TileSheetColumnIndex && pbMapTile.TileSheetRowIndex == _pbTileActionPending.TileSheetRowIndex)
        {
          pbMapTile.TileType = type;
        }
      }
    }

    private void UpdateMapTileType(FlowLayoutPanel parent, int controlIndex, Globals.TileType type)
    {
      TileSheetPictureBox pbTileSheetTile = (TileSheetPictureBox)parent.Controls[controlIndex];
      foreach (TileSheetPictureBox pbMapTile in pnlTileMap.Controls)
      {
        if (pbMapTile.TileSheetColumnIndex == pbTileSheetTile.TileSheetColumnIndex && pbMapTile.TileSheetRowIndex == pbTileSheetTile.TileSheetRowIndex)
        {
          pbMapTile.TileType = type;
        }
      }
    }

    private void tsmiClearMapTileSelection_Click(object sender, EventArgs e)
    {
      foreach (TileSheetPictureBox pbMapTile in pnlTileMap.Controls)
      {
        pbMapTile.BorderStyle = BorderStyle.None;
      }

      _liSelectedMapTileIndices.Clear();
    }

    private void MoveMultipleMapTiles(Globals.TileType newType)
    {
      FlowLayoutPanel flpTileSheetParent = null;
      TileSheetPictureBox pbMapTile;
      List<string> lsTileSheetRowColumnIndicesMoved = new List<string>();

      foreach (int iSelectedIndex in _liSelectedMapTileIndices)
      {
        int iTileSheetControlIndex = -1;

        pbMapTile = (TileSheetPictureBox)pnlTileMap.Controls[iSelectedIndex];

        if (lsTileSheetRowColumnIndicesMoved.Contains(String.Format("{0}|{1}", pbMapTile.TileSheetColumnIndex.ToString(), pbMapTile.TileSheetRowIndex.ToString())))
        {
          continue;
        }

        lsTileSheetRowColumnIndicesMoved.Add(String.Format("{0}|{1}", pbMapTile.TileSheetColumnIndex.ToString(), pbMapTile.TileSheetRowIndex.ToString()));


        switch (pbMapTile.TileType)
        {
          case Globals.TileType.Regular:
            flpTileSheetParent = flpRegularTiles;
            break;

          case Globals.TileType.Solid:
            flpTileSheetParent = flpSolidTiles;
            break;

          case Globals.TileType.Overlay:
            flpTileSheetParent = flpOverlayTiles;
            break;
        }

        pbMapTile.TileType = newType;

        foreach (TileSheetPictureBox pbTileSheetTile in flpTileSheetParent.Controls)
        {
          if (pbTileSheetTile.TileSheetColumnIndex == pbMapTile.TileSheetColumnIndex && pbTileSheetTile.TileSheetRowIndex == pbMapTile.TileSheetRowIndex)
          {
            iTileSheetControlIndex = flpTileSheetParent.Controls.IndexOf(pbTileSheetTile);
            break;
          }
        }

        UpdateMapTileType(flpTileSheetParent, iTileSheetControlIndex, newType);

        TileSheetPictureBox pbNewTile = new TileSheetPictureBox();
        pbNewTile.Size = new Size(64, 64);
        pbNewTile.SizeMode = PictureBoxSizeMode.StretchImage;
        pbNewTile.Tag = pbMapTile.Tag;
        pbNewTile.Image = pbMapTile.Image;
        pbNewTile.TileType = newType;
        pbNewTile.TileSheetColumnIndex = pbMapTile.TileSheetColumnIndex;
        pbNewTile.TileSheetRowIndex = pbMapTile.TileSheetRowIndex;
        pbNewTile.ContextMenuStrip = cmsTileSheetMenu;

        flpTileSheetParent.Controls.RemoveAt(iTileSheetControlIndex);

        switch (newType)
        {
          case Globals.TileType.Regular:
            pbNewTile.Click += pbRegularTile_Click;
            flpRegularTiles.Controls.Add(pbNewTile);
            break;

          case Globals.TileType.Solid:
            pbNewTile.Click += pbSolidTile_Click;
            flpSolidTiles.Controls.Add(pbNewTile);
            break;

          case Globals.TileType.Overlay:
            pbNewTile.Click += pbOverlayTile_Click;
            flpOverlayTiles.Controls.Add(pbNewTile);
            break;
        }
      }
    }

    private void MoveSingleMapTile(Globals.TileType newType)
    {
      FlowLayoutPanel flpTileSheetParent = null;

      int iMapControlIndex = -1;
      int iTileSheetControlIndex = -1;

      foreach (TileSheetPictureBox pbMapTile in _pbTileActionPending.Parent.Controls)
      {
        if (Control.Equals(pbMapTile, _pbTileActionPending))
        {
          iMapControlIndex = _pbTileActionPending.Parent.Controls.IndexOf(pbMapTile);

          switch (pbMapTile.TileType)
          {
            case Globals.TileType.Regular:
              flpTileSheetParent = flpRegularTiles;
              break;

            case Globals.TileType.Solid:
              flpTileSheetParent = flpSolidTiles;
              break;

            case Globals.TileType.Overlay:
              flpTileSheetParent = flpOverlayTiles;
              break;
          }

          pbMapTile.TileType = newType;
          break;
        }
      }

      foreach (TileSheetPictureBox pbTileSheetTile in flpTileSheetParent.Controls)
      {
        if (pbTileSheetTile.TileSheetColumnIndex == ((TileSheetPictureBox)_pbTileActionPending.Parent.Controls[iMapControlIndex]).TileSheetColumnIndex && pbTileSheetTile.TileSheetRowIndex == ((TileSheetPictureBox)_pbTileActionPending.Parent.Controls[iMapControlIndex]).TileSheetRowIndex)
        {
          iTileSheetControlIndex = flpTileSheetParent.Controls.IndexOf(pbTileSheetTile);
          break;
        }
      }

      UpdateMapTileType(flpTileSheetParent, iTileSheetControlIndex, newType);

      TileSheetPictureBox pbNewTile = new TileSheetPictureBox();
      pbNewTile.Size = new Size(64, 64);
      pbNewTile.SizeMode = PictureBoxSizeMode.StretchImage;
      pbNewTile.Tag = ((TileSheetPictureBox)_pbTileActionPending.Parent.Controls[iMapControlIndex]).Tag;
      pbNewTile.Image = _pbTileActionPending.Image;
      pbNewTile.TileType = newType;
      pbNewTile.TileSheetColumnIndex = ((TileSheetPictureBox)_pbTileActionPending.Parent.Controls[iMapControlIndex]).TileSheetColumnIndex;
      pbNewTile.TileSheetRowIndex = ((TileSheetPictureBox)_pbTileActionPending.Parent.Controls[iMapControlIndex]).TileSheetRowIndex;
      pbNewTile.ContextMenuStrip = cmsTileSheetMenu;

      flpTileSheetParent.Controls.RemoveAt(iTileSheetControlIndex);

      pbNewTile.Click += pbRegularTile_Click;
      flpRegularTiles.Controls.Add(pbNewTile);

      switch (newType)
      {
        case Globals.TileType.Regular:
          pbNewTile.Click += pbRegularTile_Click;
          flpRegularTiles.Controls.Add(pbNewTile);
          break;

        case Globals.TileType.Solid:
          pbNewTile.Click += pbSolidTile_Click;
          flpSolidTiles.Controls.Add(pbNewTile);
          break;

        case Globals.TileType.Overlay:
          pbNewTile.Click += pbOverlayTile_Click;
          flpOverlayTiles.Controls.Add(pbNewTile);
          break;
      }
    }

    private void tsmiMoveMapTileToRegular_Click(object sender, EventArgs e)
    {
      if (_liSelectedMapTileIndices.Count > 0)
      {
        MoveMultipleMapTiles(Globals.TileType.Regular);
      }
      else
      {
        MoveSingleMapTile(Globals.TileType.Regular);
      }
    }

    private void tsmiMoveMapTileToSolid_Click(object sender, EventArgs e)
    {
      if (_liSelectedMapTileIndices.Count > 0)
      {
        MoveMultipleMapTiles(Globals.TileType.Solid);
      }
      else
      {
        MoveSingleMapTile(Globals.TileType.Solid);
      }
    }

    private void tsmiMoveMapTileToOverlay_Click(object sender, EventArgs e)
    {
      if (_liSelectedMapTileIndices.Count > 0)
      {
        MoveMultipleMapTiles(Globals.TileType.Overlay);
      }
      else
      {
        MoveSingleMapTile(Globals.TileType.Overlay);
      }
    }

    private void CopyMultipleMapTiles(Globals.TileType newType)
    {
      FlowLayoutPanel flpTileSheetParent = null;
      TileSheetPictureBox pbMapTile;
      List<string> lsTileSheetRowColumnIndicesMoved = new List<string>();

      foreach (int iSelectedIndex in _liSelectedMapTileIndices)
      {
        int iTileSheetControlIndex = -1;

        pbMapTile = (TileSheetPictureBox)pnlTileMap.Controls[iSelectedIndex];

        if (lsTileSheetRowColumnIndicesMoved.Contains(String.Format("{0}|{1}", pbMapTile.TileSheetColumnIndex.ToString(), pbMapTile.TileSheetRowIndex.ToString())))
        {
          /* We still want to update any tiles that have been selected */
          pbMapTile.TileType = newType;
          continue;
        }

        lsTileSheetRowColumnIndicesMoved.Add(String.Format("{0}|{1}", pbMapTile.TileSheetColumnIndex.ToString(), pbMapTile.TileSheetRowIndex.ToString()));

        switch (pbMapTile.TileType)
        {
          case Globals.TileType.Regular:
            flpTileSheetParent = flpRegularTiles;
            break;

          case Globals.TileType.Solid:
            flpTileSheetParent = flpSolidTiles;
            break;

          case Globals.TileType.Overlay:
            flpTileSheetParent = flpOverlayTiles;
            break;
        }

        pbMapTile.TileType = newType;

        foreach (TileSheetPictureBox pbTileSheetTile in flpTileSheetParent.Controls)
        {
          if (pbTileSheetTile.TileSheetColumnIndex == pbMapTile.TileSheetColumnIndex && pbTileSheetTile.TileSheetRowIndex == pbMapTile.TileSheetRowIndex)
          {
            iTileSheetControlIndex = flpTileSheetParent.Controls.IndexOf(pbTileSheetTile);
            break;
          }
        }

        TileSheetPictureBox pbNewTile = new TileSheetPictureBox();
        pbNewTile.Size = new Size(64, 64);
        pbNewTile.SizeMode = PictureBoxSizeMode.StretchImage;
        pbNewTile.Image = pbMapTile.Image;

        _iTileSheetColumnIndex++;

        if ((_iTileSheetColumnIndex * _iTileSheetTileWidth) >= MAX_TILE_SHEET_WIDTH)
        {
          _iTileSheetColumnCount = _iTileSheetColumnIndex - 1;

          _iTileSheetColumnIndex = 0;
          _iTileSheetRowIndex++;
        }

        if ((_iTileSheetRowIndex * _iTileSheetTileHeight) > MAX_TILE_SHEET_HEIGHT)
        {
          throw new ArgumentOutOfRangeException("Tile Sheet exceeds maximum size.");
        }

        pbNewTile.Tag = new Rectangle((_iTileSheetColumnIndex * _iTileSheetTileWidth), (_iTileSheetRowIndex * _iTileSheetTileHeight), _iTileSheetTileWidth, _iTileSheetTileHeight);
        pbNewTile.TileSheetColumnIndex = _iTileSheetColumnIndex;
        pbNewTile.TileSheetRowIndex = _iTileSheetRowIndex;

        pbNewTile.ContextMenuStrip = cmsTileSheetMenu;
        pbNewTile.TileType = newType;

        pbNewTile.Click += pbRegularTile_Click;
        flpRegularTiles.Controls.Add(pbNewTile);

        switch (newType)
        {
          case Globals.TileType.Regular:
            pbNewTile.Click += pbRegularTile_Click;
            flpRegularTiles.Controls.Add(pbNewTile);
            break;

          case Globals.TileType.Solid:
            pbNewTile.Click += pbSolidTile_Click;
            flpSolidTiles.Controls.Add(pbNewTile);
            break;

          case Globals.TileType.Overlay:
            pbNewTile.Click += pbOverlayTile_Click;
            flpOverlayTiles.Controls.Add(pbNewTile);
            break;
        }
      }
    }

    private void CopySingleMapTile(Globals.TileType newType)
    {
      FlowLayoutPanel flpTileSheetParent = null;

      int iMapControlIndex = -1;
      int iTileSheetControlIndex = -1;

      foreach (TileSheetPictureBox pbMapTile in _pbTileActionPending.Parent.Controls)
      {
        if (Control.Equals(pbMapTile, _pbTileActionPending))
        {
          iMapControlIndex = _pbTileActionPending.Parent.Controls.IndexOf(pbMapTile);

          switch (pbMapTile.TileType)
          {
            case Globals.TileType.Regular:
              flpTileSheetParent = flpRegularTiles;
              break;

            case Globals.TileType.Solid:
              flpTileSheetParent = flpSolidTiles;
              break;

            case Globals.TileType.Overlay:
              flpTileSheetParent = flpOverlayTiles;
              break;
          }

          pbMapTile.TileType = newType;
          break;
        }
      }

      foreach (TileSheetPictureBox pbTileSheetTile in flpTileSheetParent.Controls)
      {
        if (pbTileSheetTile.TileSheetColumnIndex == ((TileSheetPictureBox)_pbTileActionPending.Parent.Controls[iMapControlIndex]).TileSheetColumnIndex && pbTileSheetTile.TileSheetRowIndex == ((TileSheetPictureBox)_pbTileActionPending.Parent.Controls[iMapControlIndex]).TileSheetRowIndex)
        {
          iTileSheetControlIndex = flpTileSheetParent.Controls.IndexOf(pbTileSheetTile);
          break;
        }
      }

      TileSheetPictureBox pbNewTile = new TileSheetPictureBox();
      pbNewTile.Size = new Size(64, 64);
      pbNewTile.SizeMode = PictureBoxSizeMode.StretchImage;
      pbNewTile.Image = _pbTileActionPending.Image;

      _iTileSheetColumnIndex++;

      if ((_iTileSheetColumnIndex * _iTileSheetTileWidth) >= MAX_TILE_SHEET_WIDTH)
      {
        _iTileSheetColumnCount = _iTileSheetColumnIndex - 1;

        _iTileSheetColumnIndex = 0;
        _iTileSheetRowIndex++;
      }

      if ((_iTileSheetRowIndex * _iTileSheetTileHeight) > MAX_TILE_SHEET_HEIGHT)
      {
        throw new ArgumentOutOfRangeException("Tile Sheet exceeds maximum size.");
      }

      pbNewTile.Tag = new Rectangle((_iTileSheetColumnIndex * _iTileSheetTileWidth), (_iTileSheetRowIndex * _iTileSheetTileHeight), _iTileSheetTileWidth, _iTileSheetTileHeight);
      pbNewTile.TileSheetColumnIndex = _iTileSheetColumnIndex;
      pbNewTile.TileSheetRowIndex = _iTileSheetRowIndex;

      pbNewTile.ContextMenuStrip = cmsTileSheetMenu;
      pbNewTile.TileType = newType;

      switch (newType)
      {
        case Globals.TileType.Regular:
          pbNewTile.Click += pbRegularTile_Click;
          flpRegularTiles.Controls.Add(pbNewTile);
          break;

        case Globals.TileType.Solid:
          pbNewTile.Click += pbSolidTile_Click;
          flpSolidTiles.Controls.Add(pbNewTile);
          break;

        case Globals.TileType.Overlay:
          pbNewTile.Click += pbOverlayTile_Click;
          flpOverlayTiles.Controls.Add(pbNewTile);
          break;
      }
    }

    private void tsmiCopyMapTileToRegular_Click(object sender, EventArgs e)
    {
      if (_liSelectedMapTileIndices.Count > 0)
      {
        CopyMultipleMapTiles(Globals.TileType.Regular);
      }
      else
      {
        CopySingleMapTile(Globals.TileType.Regular);
      }
    }

    private void tsmiCopyMapTileToSolid_Click(object sender, EventArgs e)
    {
      if (_liSelectedMapTileIndices.Count > 0)
      {
        CopyMultipleMapTiles(Globals.TileType.Solid);
      }
      else
      {
        CopySingleMapTile(Globals.TileType.Solid);
      }
    }

    private void tsmiCopyMapTileToOverlay_Click(object sender, EventArgs e)
    {
      if (_liSelectedMapTileIndices.Count > 0)
      {
        CopyMultipleMapTiles(Globals.TileType.Overlay);
      }
      else
      {
        CopySingleMapTile(Globals.TileType.Overlay);
      }
    }

    private void chkHighlightRegularTiles_CheckedChanged(object sender, EventArgs e)
    {
      SetMapTileHighlighting(chkHighlightRegularTiles.Checked, Globals.TileType.Regular);
    }

    private void SetMapTileHighlighting(bool highlightingActive, Globals.TileType type)
    {
      foreach (TileSheetPictureBox pbMapTile in pnlTileMap.Controls)
      {
        if (pbMapTile.TileType == type)
        {
          pbMapTile.Highlight = highlightingActive;
        }
      }

      pnlTileMap.Refresh();
    }

    private void chkHighlightSolidTiles_CheckedChanged(object sender, EventArgs e)
    {
      SetMapTileHighlighting(chkHighlightSolidTiles.Checked, Globals.TileType.Solid);
    }

    private void chkHighlightOverlayTiles_CheckedChanged(object sender, EventArgs e)
    {
      SetMapTileHighlighting(chkHighlightOverlayTiles.Checked, Globals.TileType.Overlay);
    }

    private void tsmiImportSongisms_Click(object sender, EventArgs e)
    {
      using (OpenFileDialog dlgSongisms = new OpenFileDialog())
      {
        dlgSongisms.Filter = "PNG Files|*.png";

        dlgSongisms.Title = "Find Songisms";
        dlgSongisms.Multiselect = true;

        if (dlgSongisms.ShowDialog(this) == DialogResult.OK)
        {
          SongismPictureBox pbSongism;
          System.Drawing.Image imgSongismImage;
          foreach (string sFileName in dlgSongisms.FileNames)
          {
            pbSongism = new SongismPictureBox();
            imgSongismImage = System.Drawing.Image.FromFile(sFileName);

            pbSongism.Size = imgSongismImage.Size;
            pbSongism.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSongism.Image = imgSongismImage;
            pbSongism.BackColor = Color.Transparent;

            pbSongism.MouseDown += pbSongism_MouseDown;

            flpSongisms.Controls.Add(pbSongism);
          }
        }
      }
    }

    private void PopulateSongismAttributesControls(SongismPictureBox songism)
    {
      foreach (System.Reflection.PropertyInfo oProperty in songism.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public))
      {
        //string sPropertyName = oProperty.Name;
        if (oProperty.GetCustomAttributes(false).Length > 0)
        {

        }
      }

      txtName.Text = songism.Name;
      nudMapPositionX.Value = (int)songism.MapPosition.X;
      nudMapPositionY.Value = (int)songism.MapPosition.Y;

      nudBoundingBoxWidth.Value = (int)songism.BoundingBoxDimenions.X;
      nudBoundingBoxHeight.Value = (int)songism.BoundingBoxDimenions.Y;

      nudBoundingBoxPositionX.Value = (int)songism.BoundingBoxPosition.X;
      nudBoundingBoxPositionY.Value = (int)songism.BoundingBoxPosition.Y;

      cboState.SelectedIndex = cboState.Items.IndexOf(songism.State);
      
      chkHasPrerequisiteSongism.Checked = songism.HasPrerequisiteSongism;
      txtPrerequisiteSongism.Enabled = songism.HasPrerequisiteSongism;
      txtPrerequisiteSongism.Text = songism.PrerequisiteSongism;

      chkHasPrerequisiteInventoryItem.Checked = songism.HasPrerequisiteInventoryItem;
      txtPrerequisiteInventoryItem.Enabled = songism.HasPrerequisiteInventoryItem;
      txtPrerequisiteInventoryItem.Text = songism.PrerequisiteInventoryItem;
    }

    void pbSongism_MouseDown(object sender, MouseEventArgs e)
    {
      PopulateSongismAttributesControls((SongismPictureBox)sender);
      _pbDragging = new SongismPictureBox();
      _pbDragging.Size = (sender as SongismPictureBox).Size;
      _pbDragging.SizeMode = PictureBoxSizeMode.StretchImage;
      _pbDragging.Image = (sender as SongismPictureBox).Image;
      _pbDragging.BackColor = Color.Transparent;
      DoDragDrop((sender as SongismPictureBox), DragDropEffects.Move);
    }

    private void pnlTileMap_DragDrop(object sender, DragEventArgs e)
    {
      SongismPictureBox pbAddedSongism = _pbDragging;
      pnlTileMap.Controls.Remove(_pbDragging);

      pbAddedSongism.MouseDown += pbAddedSongism_MouseDown;

      pnlTileMap.Controls.Add(pbAddedSongism);
      pbAddedSongism.BringToFront();
      _pbDragging = null;
    }

    void pbAddedSongism_MouseDown(object sender, MouseEventArgs e)
    {
      _pbDragging = (SongismPictureBox)sender;
      _pbDragging.Size = (sender as SongismPictureBox).Size;
      _pbDragging.SizeMode = PictureBoxSizeMode.StretchImage;
      _pbDragging.Image = (sender as SongismPictureBox).Image;
      _pbDragging.BackColor = Color.Transparent;
      DoDragDrop((sender as SongismPictureBox), DragDropEffects.Move);
    }

    private void pnlTileMap_DragEnter(object sender, DragEventArgs e)
    {
      e.Effect = DragDropEffects.Move;
      pnlTileMap.Controls.Add(_pbDragging);
      _ptPreviousLocation = new Point(e.X, e.Y);
      SetThumbnailLocation(pnlTileMap.PointToClient(new Point(e.X, e.Y)));
    }

    protected void SetThumbnailLocation(Point p)
    {
      p.X -= _pbDragging.Width / 2;
      p.Y -= _pbDragging.Height / 2;
      _pbDragging.Location = p;
      _pbDragging.Visible = true;
      _pbDragging.BringToFront();
    }

    private void pnlTileMap_DragLeave(object sender, EventArgs e)
    {

    }

    private void pnlTileMap_DragOver(object sender, DragEventArgs e)
    {
      e.Effect = DragDropEffects.Move;
      if ((e.X != _ptPreviousLocation.X) && (e.Y != _ptPreviousLocation.Y))
      {
        //e.Effect = DragDropEffects.Copy;
        SetThumbnailLocation(pnlTileMap.PointToClient(new Point(e.X, e.Y)));
        //SetThumbnailLocation(new Point(e.X, e.Y));
      }

      _ptPreviousLocation = new Point(e.X, e.Y);
    }

  }
}
