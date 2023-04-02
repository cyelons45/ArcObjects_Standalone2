

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;

namespace bestaurantstandalone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void res_load_button1_Click(object sender, EventArgs e)
        {

            try
            {
               
                ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.Desktop);
                IAoInitialize ioinit = new AoInitialize();
                ioinit.Initialize(esriLicenseProductCode.esriLicenseProductCodeAdvanced);
                //Open workspace
                res_comboBox1.Items.Clear();
                IWorkspaceFactory workspacefactory = new FileGDBWorkspaceFactory();
                IWorkspace pworkspace = workspacefactory.OpenFromFile("C:\\ArcObjects\\Bestaurants.gdb", 0);

                IFeatureWorkspace featureworkspace = (IFeatureWorkspace)pworkspace;
                IFeatureClass featureclass = featureworkspace.OpenFeatureClass("Food_and_Drinks");
                var featurecursor = featureclass.Search(null, true);
                IFeature feature = featurecursor.NextFeature();
               
                while (feature != null)
                {
                    res_comboBox1.Items.Add(feature.Value[feature.Fields.FindField("NAME")]);
                    feature = featurecursor.NextFeature();
                }
                ioinit.Shutdown();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
 



        }
    }
}
