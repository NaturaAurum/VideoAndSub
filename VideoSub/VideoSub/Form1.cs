using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;


namespace VideoSub
{
    public partial class Form1 : Form
    {
        private string selectedPath = string.Empty;
        private List<string> targetPathList = new List<string>();
        private List<string> videoNameList = new List<string>();
        private List<FileInfo> subFiles = new List<FileInfo>();

        public Form1()
        {
            InitializeComponent();
            Init();
            LoadPath();
        }

        private void Init()
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        protected override bool ProcessCmdKey( ref Message msg, Keys keyData )
        {
            if ( keyData == Keys.Escape )
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey( ref msg, keyData );
        }

        private void btnLoad_Click( object sender, EventArgs e )
        {
            LoadPath();
        }

        private void btnDoChange_Click( object sender, EventArgs e )
        {
            if ( !string.IsNullOrEmpty( selectedPath ) )
            {
                RenameAllfile();
            }
        }

        private void RenameAllfile()
        {
            DirectoryInfo dInfo = new DirectoryInfo( @selectedPath );
            FileInfo[] fInfos = dInfo.GetFiles();

            foreach ( FileInfo f in fInfos )
            {
                if ( f.FullName.Contains( ".smi" ) )
                {
                    subFiles.Add( f );
                    
                }
                else
                {
                    videoNameList.Add( f.FullName );
                }
            }


            subFiles.Sort( ( a, b ) => StringLogicalComparer.Compare( a.Name, b.Name ) );

            int i = 0;

            foreach ( FileInfo f in subFiles )
            {
                string subName = videoNameList[ i ].Remove( videoNameList[ i ].Length - 3, 3 );
                File.Move( f.FullName, subName + "smi" );
                ++i;
            }
        }

        private void LoadPath()
        {
            IntPtr hWnd = FindWindow( null, "Directory" );
            var t = Type.GetTypeFromProgID( "Shell.Application" );
            dynamic o = Activator.CreateInstance( t );
            try
            {
                var ws = o.Windows();
                for ( int i = 0; i < ws.count; ++i )
                {
                    var ie = ws.Item( i );
                    if ( ie == null )
                    {
                        continue;
                    }
                    var path = Path.GetFileName( ( string ) ie.FullName );
                    if ( path.ToLower() == "explorer.exe" )
                    {
                        string _s = ie.document.focuseditem.path;
                        var split = _s.Split( '\\' );
                        _s = _s.Substring(0 ,( _s.Length - 1 ) - ( split[ split.Length - 1 ].Length - 1 ) );
                        _s = _s.Remove( _s.Length - 1 );
                        targetPathList.Add( _s );
                        _s = split[ split.Length - 2 ];
                        PathList.Items.Add( _s );
                    }
                }
            }
            finally
            {
                Marshal.FinalReleaseComObject( o );
            }
        }

        [DllImport( "user32.dll", SetLastError = true )]
        public static extern IntPtr FindWindow( string lpClassName, string lpWindowName );

        private void btnClear_Click( object sender, EventArgs e )
        {
            PathList.Items.Clear();
            targetPathList.Clear();
        }

        private void PathList_SelectedIndexChanged( object sender, EventArgs e )
        {
            if ( PathList.SelectedItem != null )
            {
                selectedPath = targetPathList[ PathList.SelectedIndex ];
            }
        }

        private void btnAFN_Click( object sender, EventArgs e )
        {

        }
    }
}
