using EntitiesCodeFirst.Entity;
namespace EntitiesCodeFirst
{//appconfig dosyas� bende olmad��� i�in add-xml diyerek projeye ben ekledim
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Context c = new Context();
			c.Database.Create();

		}
	}
}
