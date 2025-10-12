using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_EgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Tbl_Location.Count().ToString();
            lblSumCapasity.Text = db.Tbl_Location.Sum(x => x.LocationCapacity).ToString();
            lblGuideCount.Text = db.Tbl_Guide.Count().ToString();
            lblAvgCapacity.Text = db.Tbl_Location.Average(x => x.LocationCapacity).ToString();
            lblAvgLocationPrice.Text = db.Tbl_Location.Average(x => x.LocationPrice).ToString() + "TL";

            int lastCountryID = db.Tbl_Location.Max(x => x.LocationID);
            lblLastCountryName.Text = db.Tbl_Location.Where(x => x.LocationID == lastCountryID).Select(y => y.LocationCountry).FirstOrDefault();

            lblCappadociaLocationCapacity.Text = db.Tbl_Location.Where(x => x.LocationCity == "Kapadokya").Select(y => y.LocationCapacity).FirstOrDefault().ToString();
            lblTurkiyeCapacityAvg.Text = db.Tbl_Location.Where(x=>x.LocationCountry=="Türkiye").Average(y => y.LocationCapacity).ToString();

            var orduGuideID = db.Tbl_Location.Where(x=>x.LocationCity == "Ordu Turistik").Select(y=>y.GuideID).FirstOrDefault();
            lblOrduGuideName.Text = db.Tbl_Guide.Where(x => x.GuideID == orduGuideID).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();

            var maxCapacityLoc=db.Tbl_Location.Max(x=>x.LocationCapacity);
            lblMaxCapacityLocation.Text = db.Tbl_Location.Where(x=>x.LocationCapacity==maxCapacityLoc).Select(y=>y.LocationCity).FirstOrDefault().ToString();

            var maxPriceLoc =db.Tbl_Location.Max(x=>x.LocationPrice);
            lblMaxPriceLocation.Text = db.Tbl_Location.Where(x=>x.LocationPrice == maxPriceLoc).Select(y=>y.LocationCity).FirstOrDefault().ToString();

            var guideIdByNameCemYilmaz = db.Tbl_Guide.Where(x => x.GuideName == "Cem" && x.GuideSurname == "Yılmaz").Select(y => y.GuideID).FirstOrDefault();
            lblCemYilmazTourCount.Text = db.Tbl_Location.Where(x=>x.GuideID == guideIdByNameCemYilmaz).Count().ToString();
        }
    }
}
