using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
	public partial class FrmStatistics : Form
	{
		public FrmStatistics()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
		private void FrmStatistics_Load(object sender, EventArgs e)
		{
         
			label2.Text = db.Location.Count().ToString();
	     

		}

		private void label16_Click(object sender, EventArgs e)
		{

		}

		private void label12_Click(object sender, EventArgs e)
		{

		}

		private void label20_Click(object sender, EventArgs e)
		{

		}
	}
}
